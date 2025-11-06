using AutoMapper;
using Electro.Shop.BLL.DTOs.Products;
using Electro.Shop.DAL.Entities.Products;
using Electro.Shop.DAL.Persistence.UOW;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace Electro.Shop.BLL.Services.Products
{
    public class ProductService(IUnitOfWork unitOfWork, IMapper mapper) : IProductService
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;
        private readonly IMapper _mapper = mapper;
        private bool _disposed = false;


        public async ValueTask DisposeAsync()
        {
            if (!_disposed)
            {
                await _unitOfWork.DisposeAsync();
                _disposed = true;
            }
        }
        
        public async Task<Product?> GetOneAsync(int id, CancellationToken cancellationToken = default)
        {
            var product = await _unitOfWork.Repository<Product>()
                .GetOneAsync(P => P.Id == id, cancellationToken: cancellationToken);

            return product ?? throw new KeyNotFoundException($"Product with {id} not found");
        }
        public async Task<Product?> GetOneAsync(Expression<Func<Product, bool>>? expression = null, Expression<Func<Product, object>>[]? includes = null, bool tracked = true, CancellationToken cancellationToken = default)
        {
            var product = (await GetAllAsync(expression, includes, tracked, cancellationToken)).FirstOrDefault();

            return product is not null ? product : throw new KeyNotFoundException($"I Can't found It");
        }
        
        public async Task<IEnumerable<Product>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var products = await _unitOfWork.Repository<Product>().GetAllAsync(cancellationToken: cancellationToken);

            return products is not null ? products : throw new NullReferenceException("Sorry, There are no Products");

        }
        public async Task<IEnumerable<Product>> GetAllAsync(Expression<Func<Product, bool>>? expression = null, Expression<Func<Product, object>>[]? includes = null, bool tracked = true, CancellationToken cancellationToken = default)
        {
            var products = await _unitOfWork.Repository<Product>().GetAllAsync(expression, includes, tracked, cancellationToken);

            return _mapper.Map<IEnumerable<Product>>(products);
        }


        public async Task<int> CreateAsync(Product entity, CancellationToken cancellationToken = default)
        {
            if (entity is null)
                throw new ArgumentNullException(nameof(entity));

            // التحقق من البيانات
            if (string.IsNullOrWhiteSpace(entity.Name))
                throw new ValidationException("Product name is required");

            await _unitOfWork.Repository<Product>().CreateAsync(entity, cancellationToken);
            return await _unitOfWork.CommitAsync(cancellationToken);
        }
        public async Task UpdateAsync(Product entity, CancellationToken cancellationToken = default)
        {
            if (entity is null)
                throw new KeyNotFoundException($"Product is null");

            _unitOfWork.Repository<Product>().Update(entity);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
        public async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            var product = await GetOneAsync(id, cancellationToken) ?? throw new KeyNotFoundException($"Product with {id} not found");

            _unitOfWork.Repository<Product>().Delete(product);
            await _unitOfWork.CommitAsync(cancellationToken);
        }
    }
}
