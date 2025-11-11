using Electro.Shop.DAL.Persistence.Data.Context;
using Electro.Shop.DAL.Persistence.Data.Seeding.Common;
using Electro.Shop.DAL.Persistence.Data.Seeding.Entities.Products;
using Electro.Shop.DAL.Persistence.Data.Seeding.Entities.Users;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Electro.Shop.DAL.Persistence.Data.Seeding
{
    public static class ApplicationDbContextSeeder
    {
        public static async Task SeedAsync(ApplicationDbContext context, IServiceProvider services, CancellationToken cancellationToken = default)
        {
            var logger = services.GetRequiredService<ILoggerFactory>().CreateLogger("ApplicationDbContextSeeder");

            try
            {
                var config = services.GetRequiredService<IConfiguration>();

                var seeders = new List<ISeeder>
                {
                    new UserSeeder(config),
                    new RoleSeeder(),
                    new CategorySeeder(),
                    new SubCategorySeeder(),
                    new CollectionSeeder(),
                    new BrandSeeder(),
                    new ProductSeeder(),
                    new ProductImageSeeder()
                };

                foreach (var seeder in seeders)
                {
                    await seeder.SeedAsync(context, cancellationToken);
                }

                logger.LogInformation("✅ Database seeding completed successfully.");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "❌ Error while seeding the database.");
                throw;
            }
        }
    }
}
