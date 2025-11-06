using Electro.Shop.DAL.Persistence.Data.Context;
using Electro.Shop.DAL.Persistence.Data.Seeding.Common;
using Microsoft.Extensions.Configuration;

namespace Electro.Shop.DAL.Persistence.Data.Seeding.Entities.Users
{
    internal class UserSeeder(IConfiguration config) : ISeeder
    {
        private readonly IConfiguration _config = config;

        public async Task SeedAsync(ApplicationDbContext context, CancellationToken cancellationToken = default)
        {
            var adminEmail = _config["AdminUser:Email"] ?? "admin@electroshop.com";
            var adminPassword = _config["AdminUser:Password"] ?? "WriteYourPasswordHere!";

            if (await context.Users.AnyAsync(u => u.Email == adminEmail, cancellationToken))
                return;

            var hash = BCrypt.Net.BCrypt.HashPassword(adminPassword);

            var admin = new User
            {
                FullName = "Keroles Hanna",
                Email = adminEmail,
                PasswordHash = hash,
                Phone = "01271473839",
                CreatedById = 1, // system
                IsActive = true,
                CreatedOn = DateTime.UtcNow
            };

            await context.Users.AddAsync(admin, cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
