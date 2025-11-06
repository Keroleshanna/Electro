namespace Electro.Shop.DAL.Entities.Products
{
    public class ProductImage : BaseAuditableEntity<int>
    {
        public int ProductId { get; set; }
        public string ImageUrl { get; set; } = null!;
        public bool IsMain { get; set; } = false;

        // Navigation
        public Product Product { get; set; } = null!;
    }
}
