using Electro.Shop.DAL.Persistence.Data.Context;
using Electro.Shop.DAL.Persistence.Repositories;
using Electro.Shop.DAL.Persistence.UOW;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Electro.Shop.DAL
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDataAccessL(this IServiceCollection services, IConfiguration builder)
        {
            services.AddDbContext<ApplicationDbContext>(option =>
            {
                option.UseSqlServer(builder.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
           
            return services;
        }
    }
}
