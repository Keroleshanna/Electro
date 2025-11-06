
namespace Electro.Shop.DAL.Persistence.Data.Common.Entites
{
    public class BaseEntityConfiguration<TEntity, TKey> : IEntityTypeConfiguration<TEntity>
        where TKey : IEquatable<TKey>
        where TEntity : BaseEntity<TKey>
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            if (typeof(TKey) == typeof(int) || typeof(TKey) == typeof(long))
            {
                builder.Property(B => B.Id).UseIdentityColumn(1,1);
            }
            else if (typeof(TKey) == typeof(Guid))
            {
                builder.Property(B => B.Id)
                       .HasDefaultValueSql("NEWID()");
            }
        }
    }
}
