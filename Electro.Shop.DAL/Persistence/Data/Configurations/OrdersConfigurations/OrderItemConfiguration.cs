
namespace Electro.Shop.DAL.Persistence.Data.Configurations.OrdersConfigurations
{
    public class OrderItemConfiguration : BaseAuditableEntityConfigurations<OrderItem, int>
    {
        public override void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            base.Configure(builder);

            builder.Property(oi => oi.Quantity)
                    .IsRequired();

            builder.Property(oi => oi.UnitPrice)
                   .HasColumnType("decimal(9,2)")
                   .IsRequired();

            // العلاقة مع Order
            builder.HasOne(oi => oi.Order)
                   .WithMany(o => o.OrderItems)
                   .HasForeignKey(oi => oi.OrderId)
                   .OnDelete(DeleteBehavior.Cascade);// لو الطلب اتحذف → العناصر تتحذف (منطقي جدًا)

            // العلاقة مع Product
            builder.HasOne(oi => oi.Product)
                   .WithMany(p => p.OrderItems)
                   .HasForeignKey(oi => oi.ProductId)
                   .OnDelete(DeleteBehavior.Restrict);// لو المنتج اتحذف → ماينفعش نحذف العناصر (عشان نحتفظ بالسجلات التاريخية)
        }

    }
}
