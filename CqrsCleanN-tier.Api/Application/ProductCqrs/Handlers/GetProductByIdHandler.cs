using CqrsCleanN_tier.Api.Application.ProductCqrs.Queries;
using CqrsCleanN_tier.Domain.Entities;
using CqrsCleanN_tier.Domain.Interfaces;

namespace CqrsCleanN_tier.Api.Application.ProductCqrs.Handlers
{
    public class GetProductByIdHandler
    {
        private readonly IProductRepository _productRepository;
        public GetProductByIdHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<Product> Handle(GetProductByIdQuery query)
        {
            return await _productRepository.GetByIdAsync(query.Id);
        }
    }
}
