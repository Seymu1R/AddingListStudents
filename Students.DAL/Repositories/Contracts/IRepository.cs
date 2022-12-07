﻿using University.DAL.Base;

namespace University.DAL.Repositories.Contracts
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<IList<T>> GetAllAsync();
        Task<T> GetAsync(int? id);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int? id);
        Task DeleteAsync(T entity);
        Task AddAsync(T entity);
        Task AddAllAsync(IEnumerable<T> entities);
        Task AddAllpAsync(params T[] entities);
    }
}
