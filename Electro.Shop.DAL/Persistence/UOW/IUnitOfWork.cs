using Electro.Shop.DAL.Persistence.Reposatories;

namespace Electro.Shop.DAL.Persistence.UOW
{
    public interface IUnitOfWork : IDisposable, IAsyncDisposable
    {
        IRepository<T> Repository<T>() where T : class;

        Task<int> CommitAsync(CancellationToken cancellationToken = default);
    }
}