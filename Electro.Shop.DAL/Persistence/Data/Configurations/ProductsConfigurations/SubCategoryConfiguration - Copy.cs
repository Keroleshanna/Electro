
namespace Electro.Shop.DAL.Persistence.Data.Configurations.ProductsConfigurations
{
    public class SubCategoryConfiguration : BaseAuditableEntityConfigurations<SubCategory, int>
    {
        public override void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            base.Configure(builder);

            builder.Property(c => c.Name)
                   .HasMaxLength(150)
                   .IsRequired();

            builder.Property(c => c.Description)
                   .HasMaxLength(500);

            builder.HasMany(c => c.Collections)
                  .WithOne(p => p.SubCategory)
                  .HasForeignKey(p => p.SubCategoryId)
                  .OnDelete(DeleteBehavior.Restrict);//

            builder.HasMany(sc => sc.Collections)
                .WithOne(col => col.SubCategory)
                .HasForeignKey(col => col.SubCategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
