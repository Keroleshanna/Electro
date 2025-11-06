
namespace Electro.Shop.DAL.Entities.Users
{
    public class Permission : BaseEntity<int>
    {
        public string Code { get; set; } = null!;
        public string? Description { get; set; }

        // Navigation
        public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    }
}
