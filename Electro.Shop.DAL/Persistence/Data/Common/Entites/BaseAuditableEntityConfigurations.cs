

namespace Electro.Shop.DAL.Persistence.Data.Common.Entites
{
    public class BaseAuditableEntityConfigurations<TEntity, TKey> : BaseEntityConfiguration<TEntity, TKey>
        where TKey : IEquatable<TKey>
        where TEntity : BaseAuditableEntity<TKey>
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.CreatedOn)
                   .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(e => e.LastModifiedOn)
                   .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(e => e.IsDeleted)
                   .HasDefaultValue(false);

            // علاقات المستخدمين
            builder.HasOne(e => e.CreatedByUser)
                   .WithMany()
                   .HasForeignKey(e => e.CreatedById)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.LastModifiedByUser)
                   .WithMany()
                   .HasForeignKey(e => e.LastModifiedById)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.DeletedByUser)
                   .WithMany()
                   .HasForeignKey(e => e.DeletedById)
                   .OnDelete(DeleteBehavior.Restrict);

            // فلتر Soft Delete
            builder.HasQueryFilter(e => !e.IsDeleted);
        }
    }
}
