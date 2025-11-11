using Electro.Shop.BLL.DTOs.Coomon;
using Electro.Shop.BLL.DTOs.Products;


namespace Electro.Shop.BLL.Services.Products
{
    public interface IProductService
    {
        Task<PagedResultDto<ProductReadDto>> GetAllProductsAsync(string search = "default", int pageNumber = 1, int pageSize = 9, string sortedBy = "default", CancellationToken cancellationToken = default);

        Task<ProductDetailsDto> GetOneProductAsync(int id, CancellationToken cancellationToken = default);
    }
}
