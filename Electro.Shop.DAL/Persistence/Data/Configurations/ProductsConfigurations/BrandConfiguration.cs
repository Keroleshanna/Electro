
namespace Electro.Shop.DAL.Persistence.Data.Configurations.ProductsConfigurations
{
    public class BrandConfiguration : BaseAuditableEntityConfigurations<Brand, int>
    {
        public override void Configure(EntityTypeBuilder<Brand> builder)
        {
            base.Configure(builder);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(b => b.Description)
                .HasMaxLength(500);

            builder.Property(b => b.LogoUrl)
                .HasMaxLength(500);

            builder.Property(b => b.CreatedOn)
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(b => b.LastModifiedOn)
                .HasDefaultValueSql("GETUTCDATE()");

            builder.Property(b => b.IsDeleted)
                .HasDefaultValue(false);

            builder.HasIndex(b => b.Name).IsUnique();
        }
    }
}
