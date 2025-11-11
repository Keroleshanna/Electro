namespace Electro.Shop.DAL.Entities.Products
{
    public class Collection : BaseAuditableEntity<int>
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        // Relations
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; } = null!;

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
