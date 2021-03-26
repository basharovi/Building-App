using Entity = Building.Domain.Entities;
using Dapper.Application.Interfaces;

namespace Building.DAL.Repositories
{
    public interface IObjectRepository : IGenericRepository<Entity.Object>
    {

    }
}
