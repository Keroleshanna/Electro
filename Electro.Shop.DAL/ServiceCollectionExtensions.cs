using Electro.Shop.DAL.Persistence.Data.Context;
using Electro.Shop.DAL.Persistence.Reposatories;
using Electro.Shop.DAL.Persistence.UOW;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Electro.Shop.DAL
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration bulider)
        {
            services.AddDbContext<ApplicationDbContext>(option =>
            {
                option.UseSqlServer(bulider.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            
            return services;
        }
    }
}
