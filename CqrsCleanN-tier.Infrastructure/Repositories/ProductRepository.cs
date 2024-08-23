using Dapper;
using CqrsCleanN_tier.Domain.Entities;
using CqrsCleanN_tier.Domain.Interfaces;
using CqrsCleanN_tier.Infrastructure.Data;

namespace CqrsCleanN_tier.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbConnection _dbConnection;

        public ProductRepository(DbConnection dbConnection)
        {
            _dbConnection = dbConnection ?? throw new ArgumentNullException(nameof(dbConnection));
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            using var connection = _dbConnection.GetConnection();
            return await connection.QueryAsync<Product>("SELECT * FROM Products");
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            using var connection = _dbConnection.GetConnection();
            return await connection.QuerySingleOrDefaultAsync<Product>("SELECT * FROM Products WHERE Id = @Id", new { Id = id });
        }
        public async Task<int> CreateAsync(Product product)
        {
            using var connection = _dbConnection.GetConnection();
            return await connection.ExecuteScalarAsync<int>("INSERT INTO Products (Name,Price) VALUES (@Name,@Price); SELECT SCOPE_IDENTITY()", product);
        }
        public async Task UpdateAsync(Product product)
        {
            using var connection = _dbConnection.GetConnection();
            await connection.ExecuteAsync("UPDATE Products SET Name = @Name, Price=@Price WHERE Id=@Id", product);
        }
        public async Task DeleteAsync(int id)
        {
            using var connection = _dbConnection.GetConnection();
            await connection.ExecuteAsync("DELETE FROM Products WHERE Id=@Id",new { Id = id });
        }
    }
}
