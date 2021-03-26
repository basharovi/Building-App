using Building.Domain;
using Building.Domain.Entities;
using Dapper.Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Building.DAL.Repositories
{
    public interface IReadingRepository : IGenericRepository<Reading>
    {
        Task<IReadOnlyList<Reading>> GetAllFilteredAsync(ReadingDto readingDto);
    }
}
