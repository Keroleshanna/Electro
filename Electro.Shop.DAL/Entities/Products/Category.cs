namespace Electro.Shop.DAL.Entities.Products
{
    public class Category : BaseAuditableEntity<int>
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        // Navigation
        public ICollection<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
        
    }
}
