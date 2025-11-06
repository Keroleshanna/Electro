namespace Electro.Shop.DAL.Entities.Products
{
    public class Review : BaseAuditableEntity<int>
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }

        // Navigation
        public User User { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }
}
