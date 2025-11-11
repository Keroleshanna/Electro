namespace Electro.Shop.DAL.Persistence.UOW
{
    using Electro.Shop.DAL.Persistence.Repositories;

    /// <summary>
    /// Defines the Unit of Work contract for coordinating repository operations.
    /// </summary>
    public interface IUnitOfWork : IAsyncDisposable
    {
        /// <summary>
        /// Retrieves a repository for a given entity type.
        /// </summary>
        IRepository<T> Repository<T>() where T : class;

        /// <summary>
        /// Commits all pending changes in a single database transaction.
        /// </summary>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Begins a new database transaction.
        /// </summary>
        Task BeginTransactionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Commits the current transaction.
        /// </summary>
        Task CommitTransactionAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Rolls back the current transaction.
        /// </summary>
        Task RollbackTransactionAsync(CancellationToken cancellationToken = default);
    }
}