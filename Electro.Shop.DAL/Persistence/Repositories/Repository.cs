using System.Linq.Expressions;

namespace Electro.Shop.DAL.Persistence.Repositories
{

    /// <summary>
    /// Generic repository implementation using Entity Framework Core with soft delete & pagination.
    /// </summary>
    public class Repository<T>(DbContext context) : IRepository<T> where T : class
    {
        private readonly DbContext _context = context ?? throw new ArgumentNullException(nameof(context));
        private readonly DbSet<T> _dbSet = context.Set<T>();


        public async Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            // استخدام ConfigureAwait يقلل overhead في الـ async context (خصوصًا في APIs).
            await _dbSet.AddAsync(entity, cancellationToken).ConfigureAwait(false);
            return entity;
        }

        public void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _dbSet.Update(entity);
        }

        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _dbSet.Remove(entity);
        }

        public void SoftDelete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            // Check if entity has an "IsDeleted" property (convention-based)
            var prop = typeof(T).GetProperty("IsDeleted");
            if (prop != null && prop.PropertyType == typeof(bool))
            {
                prop.SetValue(entity, true);
                Update(entity);
            }
            else
            {
                // If not supported, fallback to hard delete
                Delete(entity);
            }
        }

        public IQueryable<T> GetQueryable(
            Expression<Func<T, bool>>? expression = null,
            bool tracked = true,
            params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _dbSet;

            if (!tracked)
                query = query.AsNoTracking();

            if (expression != null)
                query = query.Where(expression);

            if (includes != null && includes.Length > 0)
            {
                foreach (var item in includes)
                {
                    query = query.Include(item);
                }
            }
            // query = includes.Aggregate(query, (current, include) => current.Include(include)); // Syntax sugar from foreach

            return query;
        }

        public async Task<List<T>> GetListAsync(
            Expression<Func<T, bool>>? expression = null,
            bool tracked = true,
            CancellationToken cancellationToken = default,
            params Expression<Func<T, object>>[] includes)
        {
            return await GetQueryable(expression, tracked, includes)
                .ToListAsync(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<T?> GetSingleAsync(
            Expression<Func<T, bool>>? expression = null,
            bool tracked = true,
            CancellationToken cancellationToken = default,
            params Expression<Func<T, object>>[] includes)
        {
            return await GetQueryable(expression, tracked, includes)
                .FirstOrDefaultAsync(cancellationToken)
                .ConfigureAwait(false);
        }

        public async Task<int> CountAsync(
            Expression<Func<T, bool>>? expression = null,
            CancellationToken cancellationToken = default)
        {
            return expression == null
                ? await _dbSet.CountAsync(cancellationToken).ConfigureAwait(false)
                : await _dbSet.CountAsync(expression, cancellationToken).ConfigureAwait(false);
        }

        public async Task<(List<T> Items, int TotalCount)> GetPagedListAsync(
            Expression<Func<T, bool>>? expression = null,
            int pageNumber = 1,
            int pageSize = 10,
            bool tracked = true,
            CancellationToken cancellationToken = default,
            params Expression<Func<T, object>>[] includes)
        {
            if (pageNumber < 1) pageNumber = 1;
            if (pageSize < 1) pageSize = 10;

            var query = GetQueryable(expression, tracked, includes);
            var totalCount = await query.CountAsync(cancellationToken).ConfigureAwait(false);
            var items = await query.Skip((pageNumber - 1) * pageSize)
                                   .Take(pageSize)
                                   .ToListAsync(cancellationToken)
                                   .ConfigureAwait(false);

            return (items, totalCount);
        }


        public async Task<bool> ExistsAsync(
            Expression<Func<T, bool>>? expression = null,
            CancellationToken cancellationToken = default)
        {
            return expression == null
                ? await _dbSet.AnyAsync(cancellationToken).ConfigureAwait(false)
                : await _dbSet.AnyAsync(expression, cancellationToken).ConfigureAwait(false);
        }
    }
}