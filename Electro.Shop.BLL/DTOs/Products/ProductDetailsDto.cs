namespace Electro.Shop.BLL.DTOs.Products
{
    public class ProductDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string? Size { get; set; }

        public List<string> Images { get; set; } = new List<string>();

    }
}
