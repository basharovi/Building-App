using Building.Domain;
using Building.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Building.BLL.Services
{
    public interface IReadingService
    {
        Task<IReadOnlyList<Reading>> GetAllAsync();
        Task<IReadOnlyList<Reading>> GetAllFilteredAsync(ReadingDto readingDto);
    }
}
