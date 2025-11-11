namespace Electro.Shop.DAL.Entities.Products
{
    public class Brand : BaseAuditableEntity<int>
    {

        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public string? LogoUrl { get; set; }

        // 🔗 Navigation
        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
