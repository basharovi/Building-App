using Dapper;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Entity = Building.Domain.Entities;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace Building.DAL.Repositories
{
    public class ObjectRepository : IObjectRepository
    {
        private readonly string _connectionString;

        public ObjectRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IReadOnlyList<Entity.Object>> GetAllAsync()
        {
            const string sql = "SELECT * FROM Object";
            using var connection = new SqlConnection(_connectionString);

            var result = await connection.QueryAsync<Entity.Object>(sql);
            return result.ToList();
        }
    }
}
