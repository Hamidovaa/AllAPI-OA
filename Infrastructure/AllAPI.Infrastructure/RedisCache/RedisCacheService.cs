using AllAPI.Application.Interfacee.RedisCache;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace AllAPI.Infrastructure.RedisCache
{
    public class RedisCacheService : IRedisCacheService
    {
        private readonly ConnectionMultiplexer redisConnection;
        private readonly IDatabase database;
        private readonly RedisCacheSettings settings;

        public RedisCacheService(IOptions<RedisCacheSettings> options)
        {
            settings=options.Value;
            var opt = ConfigurationOptions.Parse(settings.ConnectionString);
            redisConnection=ConnectionMultiplexer.Connect(opt);
            database= redisConnection.GetDatabase();
        }
        public async Task<T> GetAsync<T>(string key)
        {
            var value=await database.StringGetAsync(key);
            if (value.HasValue)
            {
                return JsonConvert.DeserializeObject<T>(value);
            }
            else
            {
                return default;
            }
        }

        public async Task SetAsync<T>(string key, T value, DateTime? expirationTime = null)
        {
            TimeSpan timeUntillExpiration = expirationTime.Value - DateTime.Now;
            await database.StringSetAsync(key, JsonConvert.SerializeObject(value), timeUntillExpiration);
        }
    }
}
