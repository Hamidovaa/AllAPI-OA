﻿using AllAPI.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAPI.Application.Interfacee.Repositories
{
    public interface IWriteRepository<T> where T : class, IEntityBase, new ()
    {
        Task AddAsync(T entity);
        Task AddRangeAsync(IList<T> entitities);
        Task<T> UpdateAsync(T entity);
        Task HardDeleteAsync(T entity);
        Task HardDeleteRangeAsync(IList<T> entity);

        //Task SoftDeleteAsync(T entity);
    }
}
