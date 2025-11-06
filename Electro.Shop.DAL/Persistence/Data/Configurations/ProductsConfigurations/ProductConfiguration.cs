
namespace Electro.Shop.DAL.Persistence.Data.Configurations.ProductsConfigurations
{
    public class ProductConfiguration :BaseAuditableEntityConfigurations<Product, int>
    {

        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name)
                  .HasMaxLength(200)
                  .IsRequired();

            builder.Property(p => p.Description)
                   .HasMaxLength(1000);

            builder.Property(p => p.Price)
                   .HasColumnType("decimal(9,2)")
                   .IsRequired();

            builder.Property(p => p.Stock)
                   .HasDefaultValue(0)
                   .IsRequired();

            // العلاقة مع Category
            builder.HasOne(p => p.SubCategory)
                   .WithMany(c => c.Products)
                   .HasForeignKey(p => p.SubCategoryId)
                   .OnDelete(DeleteBehavior.Restrict);// ✅ ماينفعش نحذف الكاتيجوري وتختفي المنتجات

            // العلاقة مع Review (لو عندك كلاس Review)
            builder.HasMany(p => p.Reviews)
                   .WithOne(r => r.Product)
                   .HasForeignKey(r => r.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);// ✅ حذف المنتج يحذف الريفيوهات التابعة له

            // العلاقة مع OrderItem
            builder.HasMany(p => p.OrderItems)
                   .WithOne(oi => oi.Product)
                   .HasForeignKey(oi => oi.ProductId)
                   .OnDelete(DeleteBehavior.Restrict);// ✅ ماينفعش نحذف المنتج لو ليه طلبات في النظام

            builder.HasIndex(p => new { p.Name, p.SubCategoryId }).IsUnique();

        }
    }
}
