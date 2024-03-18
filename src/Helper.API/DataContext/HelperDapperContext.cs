using Microsoft.Data.SqlClient;
using System.Data;

namespace Helper.API.DataContext
{
    public class HelperDapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public HelperDapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("HelperConStr");
        }
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
