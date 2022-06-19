using Dapper;
using MusicTaxApp.Models;
using MusicTaxApp.Repositories;
using Npgsql;

namespace MusicTaxApp.Repositories
{
    public class TestRepository : ITestRepository
    {
        private readonly string _connectionString;

        public TestRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString(("Default"));
        }

        public async Task<IEnumerable<Test>> Get()
        {
            var sqlQueay = "SELECT * FROM Tests";

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                return await connection.QueryAsync<Test>(sqlQueay);
            }
        }

        public async Task<Test> Create(Test test)
        {
            var sqlQueary = "INSERT INTO Tests(Name) VALUES (@Name)";

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(sqlQueary, new { test.Name });
                return test;
            }
        }
    }
    
}

