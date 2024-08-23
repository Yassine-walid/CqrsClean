using CqrsCleanN_tier.Api.Application.ProductCqrs.Commands;
using CqrsCleanN_tier.Domain.Entities;
using CqrsCleanN_tier.Domain.Interfaces;

namespace CqrsCleanN_tier.Api.Application.ProductCqrs.Handlers
{
    public class CreateProductHandler
    {
        private readonly IProductRepository _productRepository;
        public CreateProductHandler( IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<int> Handle(CreateProductCommand command)
        {
            var product = new Product
            {
                Name = command.Name,
                Price = command.Price,
            };
            return await _productRepository.CreateAsync(product);
        }
    }
}
