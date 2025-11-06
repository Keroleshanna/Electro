using Electro.Shop.DAL.Persistence.Data.Context;
using Electro.Shop.DAL.Persistence.Data.Seeding.Common;
using Microsoft.Extensions.Configuration;

namespace Electro.Shop.DAL.Persistence.Data.Seeding.Entities.Users
{
    internal class RoleSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext context, CancellationToken cancellationToken = default)
        {
            var user = context.Users.FirstOrDefault();

            if (user is not null && user.Id == 1 && user.Email == "admin@electroshop.com")
            {
                if (!await context.Roles.AnyAsync(u => u.Id == 1, cancellationToken))
                {

                    var Role = new Role
                    {
                        Name = "Admin",
                        Description = "Super Admin",
                        CreatedById = 1,
                        CreatedOn = DateTime.UtcNow
                    };
                    await context.Roles.AddAsync(Role, cancellationToken);
                    await context.SaveChangesAsync(cancellationToken);
                }
            }
            else
                return;

            var role = context.Roles.FirstOrDefault();

            if (user is not null && role is not null)
            {
                if (!await context.UserRoles.AnyAsync(u => u.UserId == 1 && u.RoleId == 1, cancellationToken))
                {
                    var UserRole = new UserRole
                    {
                        UserId = user.Id,
                        RoleId = role.Id
                    };
                    await context.UserRoles.AddAsync(UserRole, cancellationToken);
                    await context.SaveChangesAsync(cancellationToken);
                }
            }
            else
                return;
        }
    }
}
