using Building.DAL.UniOfWork;
using Building.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Building.BLL.Services
{
    public class DropdownLoadService : IDropdownLoadService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DropdownLoadService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<IReadOnlyList<T>> GetAllDropdownDataAsync<T>()
        {
            throw new System.NotImplementedException();
        }

        //public Task<IReadOnlyList<Reading>> GetAllAsync()
        //{
        //    return _unitOfWork.ReadingRepository.GetAllAsync();
        //}
    }
}
