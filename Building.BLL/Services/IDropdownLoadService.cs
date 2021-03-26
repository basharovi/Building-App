using Entity = Building.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Building.BLL.Services
{
    public interface IDropdownLoadService
    {
        Task<IReadOnlyList<Entity.Building>> GetBuildingDropdownDataAsync();
        Task<IReadOnlyList<Entity.DataField>> GetDataFieldDropdownDataAsync();
        Task<IReadOnlyList<Entity.Object>> GetObjectDropdownDataAsync();
    }
}
