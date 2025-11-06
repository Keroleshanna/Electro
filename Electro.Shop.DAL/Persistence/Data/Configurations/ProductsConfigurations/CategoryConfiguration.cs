
namespace Electro.Shop.DAL.Persistence.Data.Configurations.ProductsConfigurations
{
    public class CategoryConfiguration : BaseAuditableEntityConfigurations<Category, int>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);

            builder.HasIndex(c => c.Name)
                    .IsUnique();
            builder.Property(c => c.Name)
                   .HasMaxLength(150)
                   .IsRequired();

            builder.Property(c => c.Description)
                   .HasMaxLength(500);

                        
            // العلاقة مع SubCategory
            builder.HasMany(c => c.SubCategories)
                   .WithOne(p => p.Category)
                   .HasForeignKey(p => p.CategoryId)
                   .OnDelete(DeleteBehavior.Restrict);// ✅ الأفضل Restrict: نحافظ على المنتجات لو الفئة اتمسحت
        }
    }
}
