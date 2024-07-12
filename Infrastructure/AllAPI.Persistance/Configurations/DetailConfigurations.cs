using AllAPI.Domain.Entities;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAPI.Persistance.Configurations
{
    public class DetailConfigurations : IEntityTypeConfiguration<Details>
    {
        public void Configure(EntityTypeBuilder<Details> builder)
        {
            Faker faker = new("tr");

            Details details1 = new()
            {
                Id = 1,
                Title = faker.Lorem.Sentence(1),
                Description = faker.Lorem.Sentence(5),
                CategoryId = 1,
                CreateDate = DateTime.Now,
                IsDeleted = false,
            };
            Details details2 = new()
            {
                Id = 2,
                Title = faker.Lorem.Sentence(1),
                Description = faker.Lorem.Sentence(5),
                CategoryId = 3,
                CreateDate = DateTime.Now,
                IsDeleted = true,
            };
            Details details3 = new()
            {
                Id = 3,
                Title = faker.Lorem.Sentence(1),
                Description = faker.Lorem.Sentence(5),
                CategoryId = 4,
                CreateDate = DateTime.Now,
                IsDeleted = false,
            };
            builder.HasData(details1, details2, details3);
        }
    }
}
