namespace Electro.Shop.DAL.Persistence.Data.Configurations.ProductsConfigurations
{
    public class ProductImageConfiguration : BaseAuditableEntityConfigurations<ProductImage, int>
    {
        public override void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            base.Configure(builder);

            builder.Property(pi => pi.ImageUrl)
                   .IsRequired()
                   .HasMaxLength(500);

            builder.HasOne(pi => pi.Product)
                   .WithMany(p => p.ProductImages)
                   .HasForeignKey(pi => pi.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
