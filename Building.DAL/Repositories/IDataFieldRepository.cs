using Entity = Building.Domain.Entities;
using Dapper.Application.Interfaces;

namespace Building.DAL.Repositories
{
    public interface IDataFieldRepository : IGenericRepository<Entity.DataField>
    {

    }
}
