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

        public Task<IReadOnlyList<Domain.Entities.Building>> GetBuildingDropdownDataAsync()
        {
            return _unitOfWork.BuildingRepository.GetAllAsync();
        }

        public Task<IReadOnlyList<DataField>> GetDataFieldDropdownDataAsync()
        {
            return _unitOfWork.DataFieldRepository.GetAllAsync();
        }

        public Task<IReadOnlyList<Object>> GetObjectDropdownDataAsync()
        {
            return _unitOfWork.ObjectRepository.GetAllAsync();
        }
    }
}
