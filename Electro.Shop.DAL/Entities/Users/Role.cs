
namespace Electro.Shop.DAL.Entities.Users
{
    public class Role : BaseAuditableEntity<int>
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        // Navigation
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
        public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    }
}
