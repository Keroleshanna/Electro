
namespace Electro.Shop.DAL.Persistence.Data.Configurations.ProductsConfigurations
{
    public class CollectionConfiguration : BaseAuditableEntityConfigurations<Collection, int>
    {
        public override void Configure(EntityTypeBuilder<Collection> builder)
        {
            base.Configure(builder);

            builder.Property(c => c.Name)
                   .HasMaxLength(150)
                   .IsRequired();

            builder.Property(c => c.Description)
                   .HasMaxLength(500);

            // Relations
            builder.HasOne(col => col.SubCategory)
                .WithMany(sc => sc.Collections)
                .HasForeignKey(col => col.SubCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(col => col.Products)
                .WithOne(p => p.Collection)
                .HasForeignKey(p => p.CollectionId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
