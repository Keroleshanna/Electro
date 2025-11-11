using Electro.Shop.DAL.Persistence.Data.Context;
using Electro.Shop.DAL.Persistence.Data.Seeding.Common;

namespace Electro.Shop.DAL.Persistence.Data.Seeding.Entities.Products
{
    internal class ProductSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext context, CancellationToken cancellationToken = default)
        {
            if (!await context.Collections.AnyAsync(cancellationToken))
                return;

            if (await context.Products.AnyAsync(cancellationToken))
                return;

            Product[] products =
            {
                // Collection 1
                new Product() { Name = "Acer Predator Helios 300", Description = "Gaming laptop with Intel i7, 16GB RAM, 512GB SSD.", Price = 1499.99m, Stock = 20, Size = "15.6 inch", CollectionId = 1, BrandId = 1, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new Product() { Name = "Asus ROG Strix G15", Description = "High-performance gaming laptop with AMD Ryzen 9.", Price = 1599.99m, Stock = 15, Size = "15.6 inch", CollectionId = 1, BrandId = 2, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new Product() { Name = "Dell XPS 15", Description = "Premium laptop with Intel i7, 16GB RAM, 1TB SSD.", Price = 1899.99m, Stock = 10, Size = "15.6 inch", CollectionId = 1, BrandId = 3, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new Product() { Name = "HP Spectre x360", Description = "Convertible laptop with touch screen, Intel i5, 16GB RAM.", Price = 1299.99m, Stock = 25, Size = "13.3 inch", CollectionId = 1, BrandId = 4, CreatedById = 1, CreatedOn = DateTime.UtcNow },
            
                // Collection 2
                new Product() { Name = "Apple MacBook Air M2", Description = "Lightweight laptop with Apple M2 chip, 8GB RAM, 256GB SSD.", Price = 1199.99m, Stock = 30, Size = "13 inch", CollectionId = 2, BrandId = 6, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new Product() { Name = "Lenovo ThinkPad X1 Carbon", Description = "Business laptop with Intel i7, 16GB RAM, 512GB SSD.", Price = 1499.99m, Stock = 20, Size = "14 inch", CollectionId = 2, BrandId = 7, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new Product() { Name = "MSI Stealth 15M", Description = "Slim gaming laptop with Intel i7, RTX 3060, 16GB RAM.", Price = 1599.99m, Stock = 12, Size = "15.6 inch", CollectionId = 2, BrandId = 5, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new Product() { Name = "Alienware m15 R7", Description = "High-end gaming laptop with Intel i9, RTX 3070.", Price = 2399.99m, Stock = 8, Size = "15.6 inch", CollectionId = 2, BrandId = 8, CreatedById = 1, CreatedOn = DateTime.UtcNow },
            
                // Collection 3
                new Product() { Name = "Corsair One i300", Description = "Compact gaming desktop with Intel i9, RTX 3080.", Price = 2999.99m, Stock = 5, Size = "Mini Tower", CollectionId = 3, BrandId = 9, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new Product() { Name = "CyberPowerPC Gamer Supreme", Description = "Gaming desktop with AMD Ryzen 7, RTX 3070.", Price = 1899.99m, Stock = 10, Size = "Mid Tower", CollectionId = 3, BrandId = 10, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new Product() { Name = "Dell Inspiron Desktop", Description = "Reliable desktop PC for home and office.", Price = 699.99m, Stock = 20, Size = "Mini Tower", CollectionId = 3, BrandId = 3, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new Product() { Name = "HP Pavilion Desktop", Description = "Versatile desktop with Intel i5, 16GB RAM, 512GB SSD.", Price = 799.99m, Stock = 18, Size = "Mid Tower", CollectionId = 3, BrandId = 4, CreatedById = 1, CreatedOn = DateTime.UtcNow },
            
                // Collection 4
                new Product() { Name = "Samsung Galaxy S23", Description = "Flagship smartphone with Snapdragon 8 Gen 2, 8GB RAM, 256GB storage.", Price = 999.99m, Stock = 50, Size = "6.1 inch", CollectionId = 4, BrandId = 10, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new Product() { Name = "iPhone 15 Pro", Description = "Apple smartphone with A17 Bionic chip, 256GB storage.", Price = 1199.99m, Stock = 40, Size = "6.1 inch", CollectionId = 4, BrandId = 6, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new Product() { Name = "Google Pixel 8", Description = "Smartphone with Google Tensor G3 chip, 8GB RAM, 128GB storage.", Price = 899.99m, Stock = 35, Size = "6.2 inch", CollectionId = 4, BrandId = 10, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new Product() { Name = "OnePlus 11", Description = "Flagship smartphone with Snapdragon 8 Gen 2, 12GB RAM, 256GB storage.", Price = 799.99m, Stock = 30, Size = "6.7 inch", CollectionId = 4, BrandId = 10, CreatedById = 1, CreatedOn = DateTime.UtcNow }
            };


            foreach (var item in products)
                await context.Products.AddAsync(item, cancellationToken);

            await context.SaveChangesAsync(cancellationToken);

        }
    }
}
