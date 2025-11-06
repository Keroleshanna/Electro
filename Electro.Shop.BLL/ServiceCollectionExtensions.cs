using Electro.Shop.BLL.Mapping;
using Electro.Shop.BLL.Services.Products;
using Electro.Shop.DAL.Persistence.UOW;
using Microsoft.Extensions.DependencyInjection;

namespace Electro.Shop.BLL
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
