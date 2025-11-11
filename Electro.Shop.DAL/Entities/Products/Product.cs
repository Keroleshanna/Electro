namespace Electro.Shop.DAL.Entities.Products
{
    public class Product : BaseAuditableEntity<int>
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string? Size { get; set; }
        
        public int CollectionId { get; set; }
        public Collection Collection { get; set; } = null!;

        public int BrandId { get; set; }          
        public Brand Brand { get; set; } = null!;


        // Relations
        /// 🔥 بدل ما تخزن ImageUrl واحدة
        public ICollection<ProductImage> ProductImages { get; set; } = [];
        public ICollection<Review> Reviews { get; set; } = [];
        public ICollection<OrderItem> OrderItems { get; set; } = [];
    }
}
