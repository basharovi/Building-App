using Dapper;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Entity = Building.Domain.Entities;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace Building.DAL.Repositories
{
    public class BuildingRepository : IBuildingRepository
    {
        private readonly string _connectionString;

        public BuildingRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        
        public async Task<IReadOnlyList<Entity.Building>> GetAllAsync()
        {
            const string sql = "SELECT * FROM Building";
            using var connection = new SqlConnection(_connectionString);

            var result = await connection.QueryAsync<Entity.Building>(sql);
            return result.ToList();
        }
    }
}
