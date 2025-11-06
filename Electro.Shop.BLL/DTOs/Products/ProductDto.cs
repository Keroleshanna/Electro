using Electro.Shop.DAL.Entities.Products;

namespace Electro.Shop.BLL.DTOs.Products
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string? Description { get; set; }

        // الصور (ممكن تكون واحدة أو مجموعة)
        public List<ProductImageDto> Images { get; set; } = new();

        // الفئة (Category) والفرعية (SubCategory)
        public string SubCategoryName { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
    }
}
