
namespace Electro.Shop.DAL.Persistence.Data.Configurations.ProductsConfigurations
{
    public class ReviewConfiguration : BaseAuditableEntityConfigurations<Review, int>
    {
        public override void Configure(EntityTypeBuilder<Review> builder)
        {
            base.Configure(builder);

            builder.Property(r => r.Rating)
                   .IsRequired();

            builder.Property(r => r.Comment)
                   .HasMaxLength(1000);

            // العلاقة مع Product
            builder.HasOne(r => r.Product)
                   .WithMany(p => p.Reviews)
                   .HasForeignKey(r => r.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);// ✅ حذف المنتج يحذف الريفيوهات الخاصة به

            // العلاقة مع User
            builder.HasOne(r => r.User)
                   .WithMany(u => u.Reviews)
                   .HasForeignKey(r => r.UserId)
                   .OnDelete(DeleteBehavior.Restrict);// ✅ المستخدم لو اتمسح → الريفيوهات تفضل محفوظة للتاريخ


            builder.HasIndex(r => new { r.UserId, r.ProductId }).IsUnique();
            // منع المستخدم إنه يعمل أكتر من Review واحد لنفس المنتج:

        }
    }
}
