using Electro.Shop.BLL.DTOs.Products;
using Electro.Shop.BLL.Services.Common;
using Electro.Shop.DAL.Entities.Products;
using System.Linq.Expressions;


namespace Electro.Shop.BLL.Services.Products
{
    public interface IProductService : IService<Product>
    {
        Task<IEnumerable<Product>> GetAllAsync(
            Expression<Func<Product, bool>>? expression = null,
            Expression<Func<Product, object>>[]? includes = null,
            bool tracked = true,
            CancellationToken cancellationToken = default);

        Task<Product?> GetOneAsync(
            Expression<Func<Product, bool>>? expression = null,
            Expression<Func<Product, object>>[]? includes = null,
            bool tracked = true,
            CancellationToken cancellationToken = default);
    }
}
