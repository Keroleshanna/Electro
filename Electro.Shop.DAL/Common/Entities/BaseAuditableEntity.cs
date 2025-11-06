
namespace Electro.Shop.DAL.Common.Entities
{
    public class BaseAuditableEntity<TKey> : BaseEntity<TKey>
        where TKey : IEquatable<TKey>
    {
        public int CreatedById { get; set; }
        public DateTime CreatedOn { get; set; }

        public int? LastModifiedById { get; set; }
        public DateTime? LastModifiedOn { get; set; }

        public bool IsDeleted { get; set; } = false;
        public int? DeletedById { get; set; }
        public DateTime? DeletedOn { get; set; }

        // علاقات المستخدمين
        public User? CreatedByUser { get; set; }
        public User? LastModifiedByUser { get; set; }
        public User? DeletedByUser { get; set; }
    }
}
