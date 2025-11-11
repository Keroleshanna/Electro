using Electro.Shop.BLL.DTOs.Products;

namespace Electro.Shop.BLL.Services.Common
{
    public interface IService<T> where T : class
    {
        Task<ProductReadDto?> GetOneAsync(int id, CancellationToken cancellationToken = default);
        Task<IEnumerable<ProductReadDto>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<int> CreateAsync(T entity, CancellationToken cancellationToken = default);
        Task UpdateAsync(T entity, CancellationToken cancellationToken = default);
        Task DeleteAsync(int id, CancellationToken cancellationToken = default);

        //Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);
        //Task<T?> GetOneAsync(int id, CancellationToken cancellationToken = default);
        //Task<int> CreateAsync(T entity, CancellationToken cancellationToken = default);
        //Task UpdateAsync(T entity, CancellationToken cancellationToken = default);
        //Task DeleteAsync(int id, CancellationToken cancellationToken = default);
    }


}