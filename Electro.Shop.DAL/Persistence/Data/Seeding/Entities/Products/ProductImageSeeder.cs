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

            ProductImage[] productImage = [
            // Product 1
            new(){ProductId = 1, ImageUrl = "img1.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 1, ImageUrl = "img5.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 1, ImageUrl = "img9.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 1, ImageUrl = "img11.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 1, ImageUrl = "img3.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 1, ImageUrl = "img7.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
                
            // Product 2
            new(){ProductId = 6, ImageUrl = "img2.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 6, ImageUrl = "img4.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 6, ImageUrl = "img8.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 6, ImageUrl = "img10.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 6, ImageUrl = "img5.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 6, ImageUrl = "img7.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},

            // Product 3
            new(){ProductId = 11, ImageUrl = "img3.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 11, ImageUrl = "img4.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 11, ImageUrl = "img7.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 11, ImageUrl = "img9.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 11, ImageUrl = "img2.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 11, ImageUrl = "img6.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},

            // Product 4
            new(){ProductId = 16, ImageUrl = "img16.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 16, ImageUrl = "img15.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 16, ImageUrl = "img14.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 16, ImageUrl = "img13.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 16, ImageUrl = "img12.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 16, ImageUrl = "img11.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},

            // Product 5
            new(){ProductId = 21, ImageUrl = "img1.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 21, ImageUrl = "img5.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 21, ImageUrl = "img9.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 21, ImageUrl = "img11.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 21, ImageUrl = "img3.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 21, ImageUrl = "img7.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},

            // Product 2
            new(){ProductId = 26, ImageUrl = "img2.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 26, ImageUrl = "img4.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 26, ImageUrl = "img8.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 26, ImageUrl = "img10.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 26, ImageUrl = "img5.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 26, ImageUrl = "img7.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},

            // Product 3
            new(){ProductId = 31, ImageUrl = "img3.jpg", IsMain = true, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 31, ImageUrl = "img4.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 31, ImageUrl = "img7.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 31, ImageUrl = "img9.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 31, ImageUrl = "img2.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},
            new(){ProductId = 31, ImageUrl = "img6.jpg", IsMain = false, CreatedById = 1, CreatedOn = DateTime.Now},

            ];

            foreach (var item in productImage)
                await context.ProductImages.AddAsync(item, cancellationToken);

            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
