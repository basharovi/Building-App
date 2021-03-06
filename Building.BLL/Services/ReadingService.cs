using Building.DAL.UniOfWork;
using Building.Domain;
using Building.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Building.BLL.Services
{
    public class ReadingService : IReadingService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReadingService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IReadOnlyList<Reading>> GetAllAsync()
        {
            return _unitOfWork.ReadingRepository.GetAllAsync();
        }

        public Task<IReadOnlyList<Reading>> GetAllFilteredAsync(ReadingDto readingDto)
        {
            return _unitOfWork.ReadingRepository.GetAllFilteredAsync(readingDto);

        }
    }
}
