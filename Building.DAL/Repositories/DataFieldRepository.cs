using Dapper;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Entity = Building.Domain.Entities;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace Building.DAL.Repositories
{
    public class DataFieldRepository : IDataFieldRepository
    {
        private readonly string _connectionString;

        public DataFieldRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IReadOnlyList<Entity.DataField>> GetAllAsync()
        {
            const string sql = "SELECT * FROM DataField";
            using var connection = new SqlConnection(_connectionString);

            var result = await connection.QueryAsync<Entity.DataField>(sql);
            return result.ToList();
        }
    }
}
