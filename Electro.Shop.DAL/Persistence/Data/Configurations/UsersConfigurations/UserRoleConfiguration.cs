

namespace Electro.Shop.DAL.Persistence.Data.Configurations.UsersConfigurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            // composite key
            builder.HasKey(ur => new { ur.UserId, ur.RoleId });

            // relationships
            builder.HasOne(ur => ur.User)
                   .WithMany(u => u.UserRoles)
                   .HasForeignKey(ur => ur.UserId)
                   .OnDelete(DeleteBehavior.Cascade); // حذف المستخدم -> احذف الربط

            builder.HasOne(ur => ur.Role)
                   .WithMany(r => r.UserRoles)
                   .HasForeignKey(ur => ur.RoleId)
                   .OnDelete(DeleteBehavior.Restrict); // لا تمسح الدور لو مرتبط
        }
    }
}
