namespace Electro.Shop.BLL.DTOs.Products
{
    public class ParamtersIndexDto
    {
        public string Search { get; set; } = null!;
        public int Page { get; set; } = 1;
        public int Limit { get; set; } = 9;
        public string SortedBy { get; set; } = null!;
    }
}
