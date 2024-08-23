namespace CqrsCleanN_tier.Api.Application.ProductCqrs.Commands
{
    public class UpdateProductCommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
