using Dapper;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Building.Domain.Entities;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Building.Domain;

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
            using var connection = new SqlConnection(_connectionString);

            var result = await connection.QueryAsync<Reading>(sql);
            return result.ToList();
        }

        public async Task<IReadOnlyList<Reading>> GetAllFilteredAsync(ReadingDto readingDto)
        {
            var sql = $@"SELECT    [BuildingId]
                                  ,[ObjectId]
                                  ,[DatafieldId]
                                  ,[Value]
                                  ,[Timestamp]
                  FROM [BuildingDB].[dbo].[Reading]

                  WHERE [BuildingId] = {readingDto.BuildingId} 
		                AND [ObjectId] = {readingDto.ObjectId}
		                AND [DatafieldId] = {readingDto.DataFieldId}
                        AND[Timestamp] >= '{ readingDto.TimestampFrom}'
                        AND[Timestamp] <= '{ readingDto.TimestampTo}'";

            using var connection = new SqlConnection(_connectionString);

            var result = await connection.QueryAsync<Reading>(sql);
            return result.ToList();
        }
    }
}
