namespace CqrsCleanN_tier.Api.Application.ProductCqrs.Commands
{
    public class CreateProductCommand
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
