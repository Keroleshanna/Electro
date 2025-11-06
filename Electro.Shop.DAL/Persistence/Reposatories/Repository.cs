using System.Linq.Expressions;

namespace Electro.Shop.DAL.Persistence.Reposatories
{
    public class Repository<T>(DbContext context) : IRepository<T> where T : class
    {
        //private readonly DbContext _context = context;
        private readonly DbSet<T> _dbSet = context.Set<T>();

        public async Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default)
        {
            await _dbSet.AddAsync(entity, cancellationToken);
            return entity;
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync(
            Expression<Func<T, bool>>? expression = null,
            Expression<Func<T, object>>[]? includes = null,
            bool tracked = true,
            CancellationToken cancellationToken = default)
        {
            IQueryable<T> query = _dbSet;

            if (!tracked)
                query = query.AsNoTracking();

            if (expression != null)
                query = query.Where(expression);

            if (includes != null)
                foreach (var include in includes)
                    query = query.Include(include);

            return await query.ToListAsync(cancellationToken);
        }

        public async Task<T?> GetOneAsync(
            Expression<Func<T, bool>>? expression = null,
            Expression<Func<T, object>>[]? includes = null,
            bool tracked = true,
            CancellationToken cancellationToken = default)
        {
            return (await GetAllAsync(expression, includes, tracked, cancellationToken)).FirstOrDefault();
        }

        // public Task<(IEnumerable<T> Items, int TotalCount)> GetPagedAsync(
        //     Expression<Func<T, bool>>? expression = null, 
        //     Expression<Func<T, object>>[]? includes = null, 
        //     int pageNumber = 1, int pageSize = 10, 
        //     Expression<Func<T, object>>? orderBy = null, 
        //     bool ascending = true, bool tracked = false, 
        //     CancellationToken cancellationToken = default)
        // {
        //     throw new NotImplementedException();
        // }
    }
}
