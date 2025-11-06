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
                // ---- MAN ----
                new () {Name = "Clothes", CategoryId = 1, CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new() {Name = "Shoes", CategoryId = 1, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new() {Name = "Accessories", CategoryId = 1, CreatedById = 1, CreatedOn = DateTime.UtcNow },
            
                // ---- WOMAN ---
                new () {Name = "Clothes", CategoryId = 2, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new () {Name = "Shoes", CategoryId = 2, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new () {Name = "Bags", CategoryId = 2, CreatedById = 1, CreatedOn = DateTime.UtcNow },
            
                // ---- KIDS ----
                new () {Name = "Clothes", CategoryId = 3, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new () {Name = "Shoes", CategoryId = 3, CreatedById = 1, CreatedOn = DateTime.UtcNow },
                new () {Name = "Toys", CategoryId = 3, CreatedById = 1, CreatedOn = DateTime.UtcNow }
            };

            foreach (var item in subCategories)
                await context.SubCategories.AddAsync(item, cancellationToken);

            await context.SaveChangesAsync(cancellationToken);

        }
    }
}
