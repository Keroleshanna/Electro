namespace Electro.Shop.DAL.Entities.Orders
{
    public class OrderItem : BaseAuditableEntity<int>
    {
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        // Navigation
        public Order Order { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }
}
