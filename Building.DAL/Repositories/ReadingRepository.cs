using Dapper;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Building.Domain.Entities;
using System.Collections.Generic;
using Dapper.Application.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Building.DAL.Repositories
{
    public class ReadingRepository : IReadingRepository
    {
        private readonly string _connectionString;

        public ReadingRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        
        public async Task<IReadOnlyList<Reading>> GetAllAsync()
        {
            const string sql = "SELECT * FROM Reading";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var result = await connection.QueryAsync<Reading>(sql);
                return result.ToList();
            }
        }

        Task<int> IGenericRepository<Reading>.AddAsync(Reading entity)
        {
            throw new System.NotImplementedException();
        }

        Task<int> IGenericRepository<Reading>.DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        Task<Reading> IGenericRepository<Reading>.GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        Task<int> IGenericRepository<Reading>.UpdateAsync(Reading entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
