using Electro.Shop.DAL.Persistence.Data.Context;

namespace Electro.Shop.DAL.Persistence.Data.Seeding.Common
{
    internal interface ISeeder
    {
        Task SeedAsync(ApplicationDbContext context, CancellationToken cancellationToken = default);

    }
}
