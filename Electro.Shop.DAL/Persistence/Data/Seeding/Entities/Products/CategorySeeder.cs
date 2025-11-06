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
                new Category() { Name = "Men", Description = "All  things for Men", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new Category() { Name = "Women", Description = "All  things for Women", CreatedById = 1, CreatedOn = DateTime.UtcNow},
                new Category() { Name = "Kids", Description = "All  things for Kids", CreatedById = 1, CreatedOn = DateTime.UtcNow}
            ];

            foreach (var item in categories)
                await context.Categories.AddAsync(item, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
