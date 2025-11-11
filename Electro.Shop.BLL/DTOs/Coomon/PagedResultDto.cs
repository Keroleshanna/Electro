namespace Electro.Shop.BLL.DTOs.Coomon
{
    // مسؤول عن معلومات الصفحة
    public class PagedResultDto<T>
    {
        public IEnumerable<T> Products { get; set; } = new List<T>();
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public string? SortedBy { get; set; }
        public string? Search { get; set; } 
    }
}
