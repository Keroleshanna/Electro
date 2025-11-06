using Electro.Shop.DAL.Persistence.Data.Context;
using Electro.Shop.DAL.Persistence.Reposatories;


namespace Electro.Shop.DAL.Persistence.UOW
{
    public class UnitOfWork(ApplicationDbContext context) : IUnitOfWork
    {
        private readonly ApplicationDbContext _context = context ?? throw new ArgumentNullException(nameof(context));
        private readonly Dictionary<Type, object> _repositories = [];

        public IRepository<T> Repository<T>() where T : class
        {
            if (_repositories.ContainsKey(typeof(T)))
                return (IRepository<T>)_repositories[typeof(T)];

            var repoInstance = new Repository<T>(_context);
            _repositories.Add(typeof(T), repoInstance);
            return repoInstance;
        }

        public async Task<int> CommitAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                return await _context.SaveChangesAsync(cancellationToken);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
