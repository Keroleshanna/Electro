
namespace Electro.Shop.DAL.Persistence.Data.Configurations.UsersConfigurations
{
    public class RoleConfiguration : BaseAuditableEntityConfigurations<Role, int>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);

            // Name
            builder.Property(r => r.Name)
                   .IsRequired()
                   .HasMaxLength(150);

            // فهرس فريد على الاسم
            builder.HasIndex(r => r.Name).IsUnique();

            // Description
            builder.Property(r => r.Description)
                   .HasMaxLength(500);

            // العلاقة مع UserRole
            builder.HasMany(r => r.UserRoles)
                   .WithOne(ur => ur.Role)
                   .HasForeignKey(ur => ur.RoleId)
                   .OnDelete(DeleteBehavior.Restrict);// ✅ لو الدور اتحذف → العلاقات مع المستخدمين لا تتحذف 

            // العلاقة مع RolePermission
            builder.HasMany(r => r.RolePermissions)
                   .WithOne(rp => rp.Role)
                   .HasForeignKey(rp => rp.RoleId)
                   .OnDelete(DeleteBehavior.Restrict);// ✅ نفس المنطق: لو الدور اتحذف، الصلاحيات المرتبطة بيه لا تتحذف
        }
    }
}
