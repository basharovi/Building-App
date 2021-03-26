using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dapper.Application.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id) => throw new NotImplementedException();
        Task<int> AddAsync(T entity) => throw new NotImplementedException();
        Task<int> UpdateAsync(T entity) => throw new NotImplementedException();
        Task<int> DeleteAsync(int id) => throw new NotImplementedException();
    }
}
