using CqrsCleanN_tier.Api.Application.ProductCqrs.Commands;
using CqrsCleanN_tier.Api.Application.ProductCqrs.Handlers;
using CqrsCleanN_tier.Api.Application.ProductCqrs.Queries;
using CqrsCleanN_tier.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CqrsCleanN_tier.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly CreateProductHandler _createProductHandler;
        private readonly GetProductByIdHandler _getProductByIdHandler;

        public ProductController(CreateProductHandler createProductHandler, GetProductByIdHandler getProductByIdHandler)
        {
            _getProductByIdHandler = getProductByIdHandler;
            _createProductHandler = createProductHandler;
        }
        [HttpPost]
        public async Task<ActionResult<int>> CreateProduct([FromBody] CreateProductCommand command)
        {
            var productId = await _createProductHandler.Handle(command);
            return Ok(productId);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var query = new GetProductByIdQuery { Id = id };
            var product = await _getProductByIdHandler.Handle(query);
            if (product == null) {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
