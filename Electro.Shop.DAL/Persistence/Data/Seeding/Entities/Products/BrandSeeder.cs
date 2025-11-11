using Electro.Shop.DAL.Persistence.Data.Context;
using Electro.Shop.DAL.Persistence.Data.Seeding.Common;

namespace Electro.Shop.DAL.Persistence.Data.Seeding.Entities.Products
{
    public class BrandSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext context, CancellationToken cancellationToken = default)
        {
            if (await context.Brands.AnyAsync(cancellationToken))
                return;

            Brand[] brands =
            {
                new Brand() { Name = "Acer", Description = "Global PC brand for laptops and desktops.", LogoUrl = "https://example.com/logos/acer.png", CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new Brand() { Name = "Asus", Description = "Innovative laptops, motherboards, and gaming products.", LogoUrl = "https://example.com/logos/asus.png", CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new Brand() { Name = "Dell", Description = "Reliable PCs and business solutions worldwide.", LogoUrl = "https://example.com/logos/dell.png", CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new Brand() { Name = "HP", Description = "Personal computing and printing solutions.", LogoUrl = "https://example.com/logos/hp.png", CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new Brand() { Name = "MSI", Description = "High-performance gaming hardware and laptops.", LogoUrl = "https://example.com/logos/msi.png", CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new Brand() { Name = "Apple", Description = "Premium laptops and desktops with macOS.", LogoUrl = "https://example.com/logos/apple.png", CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new Brand() { Name = "Lenovo", Description = "Global PC and laptop brand for business and personal use.", LogoUrl = "https://example.com/logos/lenovo.png", CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new Brand() { Name = "Alienware", Description = "High-end gaming PCs and laptops, part of Dell.", LogoUrl = "https://example.com/logos/alienware.png", CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new Brand() { Name = "Corsair", Description = "PC components and high-performance gaming desktops.", LogoUrl = "https://example.com/logos/corsair.png", CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new Brand() { Name = "CyberPowerPC", Description = "Pre-built gaming PCs for enthusiasts and casual gamers.", LogoUrl = "https://example.com/logos/cyberpowerpc.png", CreatedById = 1, CreatedOn = DateTime.UtcNow }
            };

            foreach (var item in brands)
                await context.Brands.AddAsync(item, cancellationToken);

            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
