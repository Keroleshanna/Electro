namespace Electro.Shop.DAL.Persistence.Data.Configurations.UsersConfigurations
{
    public class PermissionConfiguration : BaseEntityConfiguration<Permission, int>
    {
        public override void Configure(EntityTypeBuilder<Permission> builder)
        {
            base.Configure(builder);

            // Code
            builder.Property(p => p.Code)
                   .IsRequired()
                   .HasMaxLength(200);

            // تأكد أن الكود فريد (لأن كل Permission لازم يكون مميز)
            builder.HasIndex(p => p.Code)
                   .IsUnique();

            // Description
            builder.Property(p => p.Description)
                   .HasMaxLength(500);

            // العلاقة مع RolePermission
            builder.HasMany(p => p.RolePermissions)
                   .WithOne(rp => rp.Permission)
                   .HasForeignKey(rp => rp.PermissionId)
                   .OnDelete(DeleteBehavior.Cascade);// ✅ منطقي: لو Permission اتمسح → كل العلاقات المرتبطة بيه تتحذف
        }
    }
}
