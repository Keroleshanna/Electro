

namespace Electro.Shop.DAL.Persistence.Data.Configurations.UsersConfigurations
{
    public class UserConfiguration :BaseAuditableEntityConfigurations<User, int>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            // FullName
            builder.Property(u => u.FullName)
                   .IsRequired()
                   .HasMaxLength(200);

            // Email
            builder.Property(u => u.Email)
                   .IsRequired()
                   .HasMaxLength(200);

            // تأكد أن البريد الإلكتروني فريد
            builder.HasIndex(u => u.Email).IsUnique();

            // PasswordHash
            builder.Property(u => u.PasswordHash)
                   .IsRequired()
                   .HasMaxLength(500);

            // Phone
            builder.Property(u => u.Phone)
                   .HasMaxLength(20);

            // IsActive
            builder.Property(u => u.IsActive)
                   .HasDefaultValue(true);

            // العلاقة مع Orders
            builder.HasMany(u => u.Orders)
                   .WithOne(o => o.User)
                   .HasForeignKey(o => o.UserId)
                   .OnDelete(DeleteBehavior.Restrict);// ✅ لو المستخدم اتمسح → الطلبات بتاعته لا تحذف (ده منطقي)

            // العلاقة مع Reviews
            builder.HasMany(u => u.Reviews)
                   .WithOne(r => r.User)
                   .HasForeignKey(r => r.UserId)
                   .OnDelete(DeleteBehavior.Restrict);// ✅ لو المستخدم اتمسح → الريفيوهات تفضل للتاريخ

            // العلاقة مع UserRoles
            builder.HasMany(u => u.UserRoles)
                   .WithOne(ur => ur.User)
                   .HasForeignKey(ur => ur.UserId)
                   .OnDelete(DeleteBehavior.Cascade);// ✅ حذف المستخدم يحذف الربط بينه وبين الأدوار
        }
    }
}
