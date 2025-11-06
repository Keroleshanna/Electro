

namespace Electro.Shop.DAL.Persistence.Data.Configurations.UsersConfigurations
{
    public class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermission>
    {
        public void Configure(EntityTypeBuilder<RolePermission> builder)
        {
            // composite key
            builder.HasKey(rp => new { rp.RoleId, rp.PermissionId });

            // relationships
            builder.HasOne(rp => rp.Role)
                   .WithMany(r => r.RolePermissions)
                   .HasForeignKey(rp => rp.RoleId)
                   .OnDelete(DeleteBehavior.Restrict); // لو حذفت الدور، امنع حذف تلقائي للعلاقات

            builder.HasOne(rp => rp.Permission)
                   .WithMany(p => p.RolePermissions)
                   .HasForeignKey(rp => rp.PermissionId)
                   .OnDelete(DeleteBehavior.Cascade); // حذف الصلاحية -> احذف الربط
        }
    }
}
