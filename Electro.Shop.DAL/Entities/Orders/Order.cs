namespace Electro.Shop.DAL.Entities.Orders
{
    public class Order : BaseAuditableEntity<int>
    {
        public decimal TotalAmount { get; set; } = 0m;
        public OrderStatus Status { get; set; } = OrderStatus.Pending;
        public int UserId { get; set; }

        // Navigation
        public User User { get; set; } = null!;
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }

    public enum OrderStatus
    {
        Pending = 1,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }
}
