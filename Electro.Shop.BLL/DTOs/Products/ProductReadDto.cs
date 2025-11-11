namespace Electro.Shop.BLL.DTOs.Products
{
    // مسؤول عن بيانات المنتج.
    public class ProductReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string? MainImage { get; set;  }
    }
}
