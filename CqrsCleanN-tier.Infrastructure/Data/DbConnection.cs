using System.Data;
using System.Diagnostics;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace CqrsCleanN_tier.Infrastructure.Data
{
    public class DbConnection : IDisposable
    {
        private   IDbConnection _connection;
        private readonly string _connectionString;

        public DbConnection(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        }
        public IDbConnection GetConnection() {
            if (_connection == null || _connection.State != ConnectionState.Open)
            {
                _connection = new SqlConnection(_connectionString);
                _connection.Open();
            }
            return _connection;
        }

        public void Dispose() {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
            _connection?.Dispose();
        }
    }
}
