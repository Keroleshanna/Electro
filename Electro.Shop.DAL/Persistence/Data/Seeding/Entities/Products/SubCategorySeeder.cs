using Electro.Shop.DAL.Persistence.Data.Context;
using Electro.Shop.DAL.Persistence.Data.Seeding.Common;

namespace Electro.Shop.DAL.Persistence.Data.Seeding.Entities.Products
{
    internal class SubCategorySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext context, CancellationToken cancellationToken = default)
        {
            if (!await context.Categories.AnyAsync(cancellationToken))
                return;

            if (await context.SubCategories.AnyAsync(cancellationToken))
                return;

            SubCategory[] subCategories =
            {
                // Computers & Laptops (CategoryId = 1)
                new SubCategory() { Name = "Laptops", CategoryId = 1, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new SubCategory() { Name = "Desktops", CategoryId = 1, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new SubCategory() { Name = "Monitors", CategoryId = 1, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new SubCategory() { Name = "PC Components", CategoryId = 1, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new SubCategory() { Name = "Accessories", CategoryId = 1, CreatedById = 1, CreatedOn = DateTime.UtcNow },

                // Mobile Phones & Accessories (CategoryId = 2)
                new SubCategory() { Name = "Smartphones", CategoryId = 2, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new SubCategory() { Name = "Chargers & Cables", CategoryId = 2, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new SubCategory() { Name = "Headphones & Earbuds", CategoryId = 2, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new SubCategory() { Name = "Phone Cases & Covers", CategoryId = 2, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new SubCategory() { Name = "Power Banks", CategoryId = 2, CreatedById = 1, CreatedOn = DateTime.UtcNow },

                // TV & Home Entertainment (CategoryId = 3)
                new SubCategory() { Name = "Televisions", CategoryId = 3, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new SubCategory() { Name = "Soundbars & Speakers", CategoryId = 3, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new SubCategory() { Name = "Projectors", CategoryId = 3, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new SubCategory() { Name = "Media Players", CategoryId = 3, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new SubCategory() { Name = "Streaming Devices", CategoryId = 3, CreatedById = 1, CreatedOn = DateTime.UtcNow }
            };


            foreach (var item in subCategories)
                await context.SubCategories.AddAsync(item, cancellationToken);

            await context.SaveChangesAsync(cancellationToken);

        }
    }
}
