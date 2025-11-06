namespace Electro.Shop.DAL.Entities.Products
{
    public class Product : BaseAuditableEntity<int>
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string? Brand { get; set; }
        public string? Size { get; set; }
        
        public int SubCategoryId { get; set; }

        // 🔥 بدل ما تخزن ImageUrl واحدة
        public ICollection<ProductImage> ProductImages { get; set; } = [];

        // Relations
        public SubCategory SubCategory { get; set; } = null!;
        public ICollection<Review> Reviews { get; set; } = [];
        public ICollection<OrderItem> OrderItems { get; set; } = [];
    }
}
