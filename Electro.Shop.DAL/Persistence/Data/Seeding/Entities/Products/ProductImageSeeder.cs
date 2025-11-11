using Electro.Shop.DAL.Persistence.Data.Context;
using Electro.Shop.DAL.Persistence.Data.Seeding.Common;

namespace Electro.Shop.DAL.Persistence.Data.Seeding.Entities.Products
{
    internal class ProductImageSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext context, CancellationToken cancellationToken = default)
        {
            if (!await context.Products.AnyAsync(cancellationToken))
                return;

            if (await context.ProductImages.AnyAsync(cancellationToken))
                return;

            ProductImage[] productImages =
            {
                // Collection 1 - Gaming Laptops
                new ProductImage() { ProductId = 40, ImageUrl = "Alienware_m15_R7_1.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 40, ImageUrl = "Alienware_m15_R7_2.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 40, ImageUrl = "Alienware_m15_R7_3.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
            
                new ProductImage() { ProductId = 41, ImageUrl = "Asus_ROG_Strix_1.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 41, ImageUrl = "Asus_ROG_Strix_2.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 41, ImageUrl = "Asus_ROG_Strix_3.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
            
                new ProductImage() { ProductId = 42, ImageUrl = "MSI_GE76_1.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 42, ImageUrl = "MSI_GE76_2.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 42, ImageUrl = "MSI_GE76_3.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
            
                new ProductImage() { ProductId = 43, ImageUrl = "Razer_Blade_15_1.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 43, ImageUrl = "Razer_Blade_15_2.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 43, ImageUrl = "Razer_Blade_15_3.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
            
                // Collection 2 - Smartphones
                new ProductImage() { ProductId = 44, ImageUrl = "iPhone_15_1.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 44, ImageUrl = "iPhone_15_2.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 44, ImageUrl = "iPhone_15_3.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
            
                new ProductImage() { ProductId = 45, ImageUrl = "Samsung_Galaxy_S24_1.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 45, ImageUrl = "Samsung_Galaxy_S24_2.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 45, ImageUrl = "Samsung_Galaxy_S24_3.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
            
                new ProductImage() { ProductId = 46, ImageUrl = "Google_Pixel_8_1.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 46, ImageUrl = "Google_Pixel_8_2.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 46, ImageUrl = "Google_Pixel_8_3.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
            
                new ProductImage() { ProductId = 47, ImageUrl = "OnePlus_12_1.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 47, ImageUrl = "OnePlus_12_2.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 47, ImageUrl = "OnePlus_12_3.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
            
                // Collection 3 - Headphones
                new ProductImage() { ProductId = 48, ImageUrl = "Sony_WH_1000XM5_1.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 48, ImageUrl = "Sony_WH_1000XM5_2.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 48, ImageUrl = "Sony_WH_1000XM5_3.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
            
                new ProductImage() { ProductId = 49, ImageUrl = "Bose_QuietComfort_45_1.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 49, ImageUrl = "Bose_QuietComfort_45_2.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 49, ImageUrl = "Bose_QuietComfort_45_3.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
            
                new ProductImage() { ProductId = 50, ImageUrl = "Apple_AirPods_Max_1.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 50, ImageUrl = "Apple_AirPods_Max_2.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 50, ImageUrl = "Apple_AirPods_Max_3.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
            
                new ProductImage() { ProductId = 51, ImageUrl = "JBL_Live_Pro_2_1.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 51, ImageUrl = "JBL_Live_Pro_2_2.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 51, ImageUrl = "JBL_Live_Pro_2_3.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
            
                // Collection 4 - Smartwatches
                new ProductImage() { ProductId = 52, ImageUrl = "Apple_Watch_Series_9_1.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 52, ImageUrl = "Apple_Watch_Series_9_2.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 52, ImageUrl = "Apple_Watch_Series_9_3.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
            
                new ProductImage() { ProductId = 53, ImageUrl = "Samsung_Galaxy_Watch_6_1.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 53, ImageUrl = "Samsung_Galaxy_Watch_6_2.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 53, ImageUrl = "Samsung_Galaxy_Watch_6_3.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
            
                new ProductImage() { ProductId = 54, ImageUrl = "Garmin_Fenix_7_1.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 54, ImageUrl = "Garmin_Fenix_7_2.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 54, ImageUrl = "Garmin_Fenix_7_3.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
            
                new ProductImage() { ProductId = 55, ImageUrl = "Fitbit_Sense_2_1.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 55, ImageUrl = "Fitbit_Sense_2_2.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new ProductImage() { ProductId = 55, ImageUrl = "Fitbit_Sense_2_3.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.UtcNow },
            };


            foreach (var item in productImages)
                await context.ProductImages.AddAsync(item, cancellationToken);

            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
