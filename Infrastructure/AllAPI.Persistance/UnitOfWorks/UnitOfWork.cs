using AllAPI.Application.Interfacee.Repositories;
using AllAPI.Application.Interfacee.UnitOfWorks;
using AllAPI.Persistance.Context;
using AllAPI.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAPI.Persistance.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbcontext;
        public UnitOfWork(AppDbContext dbContext) 
        {
            this.dbcontext = dbContext;
        }
        public async ValueTask DisposeAsync()=> await dbcontext.DisposeAsync();


        public int Save() => dbcontext.SaveChanges();
        

        public async Task<int> SaveAsync()=> await dbcontext.SaveChangesAsync();


        IReadRepository<T> IUnitOfWork.GetReadRepository<T>() => new ReadPepository<T>(dbcontext);
        

        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>() => new WriteRepository<T>(dbcontext);
       
    }
}
