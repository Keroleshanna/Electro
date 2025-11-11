using Electro.Shop.DAL.Persistence.Data.Context;
using Electro.Shop.DAL.Persistence.Data.Seeding.Common;

namespace Electro.Shop.DAL.Persistence.Data.Seeding.Entities.Products
{
    internal class CategorySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext context, CancellationToken cancellationToken = default)
        {
            var admin = context.Users.Find(1);
            if (admin is null)
                return;

            if (await context.Categories.AnyAsync(cancellationToken))
                return;

            Category[] categories =
            [
                new() { Name = "Computers & Laptops", Description = "Laptops, desktops, and all related accessories.", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Mobile Phones & Accessories", Description = "Smartphones, chargers, cases, headphones, and other mobile accessories.", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "TV & Home Entertainment", Description = "Televisions, sound systems, and home entertainment devices.", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Cameras & Photography", Description = "Digital cameras, lenses, and photography accessories.", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Gaming & Consoles", Description = "Gaming consoles, controllers, and video games.", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Home Appliances", Description = "Large and small home appliances like refrigerators, washing machines, and air conditioners.", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Wearables & Smart Devices", Description = "Smartwatches, fitness trackers, and other wearable technology.", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Audio & Headphones", Description = "Headphones, earbuds, and portable audio devices.", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() { Name = "Networking & Internet Devices", Description = "Routers, modems, and other networking equipment.", CreatedById = 1, CreatedOn = DateTime.UtcNow}
            ];

            foreach (var item in categories)
                await context.Categories.AddAsync(item, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
