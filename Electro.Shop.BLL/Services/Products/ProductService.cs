using AutoMapper;
using AutoMapper.QueryableExtensions;
using Electro.Shop.BLL.DTOs.Coomon;
using Electro.Shop.BLL.DTOs.Products;
using Electro.Shop.DAL.Entities.Products;
using Electro.Shop.DAL.Persistence.UOW;
using Microsoft.EntityFrameworkCore;

namespace Electro.Shop.BLL.Services.Products
{
    public class ProductService(IUnitOfWork unitOfWork, IMapper mapper) : IProductService
    {
        private readonly IUnitOfWork _uow = unitOfWork;
        private readonly IMapper _mapper = mapper;


        //public async Task<int> CreateAsync(Product entity, CancellationToken cancellationToken = default)
        //{
        //    var repo = _uow.Repository<Product>();
        //    if (entity is null)
        //        throw new ArgumentNullException(nameof(entity));

        //    if (string.IsNullOrEmpty(entity.Name))
        //        throw new ValidationException("Product name is required");

        //    await repo.CreateAsync(entity, cancellationToken);
        //    return await _uow.CommitAsync(cancellationToken);
        //}

        //public async Task UpdateAsync(Product entity, CancellationToken cancellationToken = default)
        //{
        //    var repo = _uow.Repository<Product>();
        //    if (entity is null)
        //        throw new ArgumentNullException(nameof(entity));

        //    if (string.IsNullOrEmpty(entity.Name))
        //        throw new ValidationException("Product name is required");

        //    repo.Update(entity);
        //    await _uow.CommitAsync(cancellationToken);
        //}

        //public async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
        //{
        //    var repo = _uow.Repository<Product>();
        //    var entity = await repo.GetSingleAsync(p => p.Id == id, tracked: false, cancellationToken: cancellationToken);
        //    if (entity is null)
        //        throw new KeyNotFoundException($"Product with id {id} not found");

        //    repo.Delete(entity);
        //    await _uow.CommitAsync(cancellationToken);
        //}

        //public async Task<IEnumerable<ProductReadDto>> GetAllAsync(CancellationToken cancellationToken = default)
        //{
        //    var repo = _uow.Repository<Product>();
        //    var products = repo.GetQueryable(tracked: false);

        //    var list = await products.ProjectTo<ProductReadDto>(_mapper.ConfigurationProvider)
        //        .ToListAsync(cancellationToken);

        //    return list;
        //}

        //public async Task<ProductReadDto?> GetOneAsync(int id, CancellationToken cancellationToken = default)
        //{
        //    var repo = _uow.Repository<Product>();
        //    // Use includes to ensure SubCategory and Category are available for mapping
        //    var query = repo.GetQueryable(p => p.Id == id, tracked: false);

        //    // Use ProjectTo for efficient projection
        //    var dto = await query.ProjectTo<ProductReadDto>(_mapper.ConfigurationProvider)
        //                                     .FirstOrDefaultAsync(cancellationToken);

        //    if (dto == null)
        //        throw new KeyNotFoundException($"Product with id {id} not found");

        //    return dto;
        //}

        public async Task<PagedResultDto<ProductReadDto>> GetAllProductsAsync(string search = "default", int pageNumber = 1, int pageSize = 9, string sortedBy = "default", CancellationToken cancellationToken = default)
        {
            if (pageNumber <= 0) pageNumber = 1;
            if (pageSize <= 0) pageSize = 9;

            var repo = _uow.Repository<Product>();

            // Base query with includes for mapping
            var query = repo.GetQueryable(expression: null, tracked: false, p => p.ProductImages);

            // Search - use EF.Functions.Like for DB-side case-insensitive (depending on collation)
            if (!string.IsNullOrWhiteSpace(search) && search != "default")
            {
                search = search.Trim();
                query = query.Where(p => EF.Functions.Like(p.Name, $"%{search}%"));
            }

            // Sorting
            query = sortedBy switch
            {
                "NameASC" => query.OrderBy(p => p.Name),
                "NameDES" => query.OrderByDescending(p => p.Name),
                "PriceASC" => query.OrderBy(p => p.Price),
                "PriceDES" => query.OrderByDescending(p => p.Price),
                _ => query.OrderByDescending(p => p.CreatedOn)
            };

            // Count after filters (async)
            var totalCount = await query.CountAsync(cancellationToken);
            var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            // 👇 هنا بنستخدم ProjectTo بدلاً من Select
            var products = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ProjectTo<ProductReadDto>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return new PagedResultDto<ProductReadDto>
            {
                Products = products,
                CurrentPage = pageNumber,
                PageSize = pageSize,
                TotalCount = totalCount,
                TotalPages = totalPages,
                SortedBy = sortedBy,
                Search = search
            };
        }

        public async Task<ProductDetailsDto> GetOneProductAsync(int id, CancellationToken cancellationToken = default)
        {
            if (id <= 0)
                throw new KeyNotFoundException($"Sorry Product with ID => {id} NOT FOUND!!");
            var repo = _uow.Repository<Product>();
            var quary = await repo.GetSingleAsync(p => p.Id == id, false, cancellationToken, p => p.ProductImages);

            if (quary is null)
                throw new NullReferenceException();

            var product = _mapper.Map<ProductDetailsDto>(quary);
            return product;

        }
    }
}
