
namespace Electro.Shop.DAL.Persistence.Data.Configurations.OrdersConfigurations
{
    public class OrderConfiguration : BaseAuditableEntityConfigurations<Order, int>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);

            builder.Property(O => O.TotalAmount)
                .HasColumnType("decimal(9,2)");

            builder.Property(O => O.Status)
                .HasConversion<string>()
                .HasMaxLength(50); // لتفادي حجز مساحة كبيرة في العمود

            builder.HasOne(o => o.User)
                   .WithMany(u => u.Orders)
                   .HasForeignKey(o => o.UserId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(o => o.OrderItems)
                   .WithOne(oi => oi.Order)
                   .HasForeignKey(oi => oi.OrderId);
        }
    }
}
