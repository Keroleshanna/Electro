namespace Electro.Shop.DAL.Entities.Products
{
    public class SubCategory : BaseAuditableEntity<int>
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        // Navigation
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
