using System.Linq.Expressions;

namespace Electro.Shop.DAL.Persistence.Repositories
{
    /// <summary>
    /// Represents a generic repository providing CRUD, query, pagination, and soft delete support.
    /// </summary>
    /// <typeparam name="T">The entity type.</typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Adds an entity to the context (not saved until UnitOfWork.SaveAsync() is called).
        /// </summary>
        Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default);

        /// <summary>
        /// Marks an entity as modified.
        /// </summary>
        void Update(T entity);

        /// <summary>
        /// Removes an entity physically from the database.
        /// </summary>
        void Delete(T entity);

        /// <summary>
        /// Performs a soft delete if the entity contains a property named "IsDeleted".
        /// </summary>
        void SoftDelete(T entity);

        /// <summary>
        /// Gets a list of entities with optional filtering, includes, and tracking.
        /// </summary>
        Task<List<T>> GetListAsync(
            Expression<Func<T, bool>>? expression = null,
            bool tracked = true,
            CancellationToken cancellationToken = default,
            params Expression<Func<T, object>>[] includes);

        /// <summary>
        /// Gets a single entity that matches the filter condition.
        /// </summary>
        Task<T?> GetSingleAsync(
            Expression<Func<T, bool>>? expression = null,
            bool tracked = true,
            CancellationToken cancellationToken = default,
            params Expression<Func<T, object>>[] includes);

        /// <summary>
        /// Gets an IQueryable for advanced filtering, sorting, and paging.
        /// </summary>
        IQueryable<T> GetQueryable(
            Expression<Func<T, bool>>? expression = null,
            bool tracked = true,
            params Expression<Func<T, object>>[] includes);

        /// <summary>
        /// Gets a paginated list of entities with optional filtering.
        /// </summary>
        Task<(List<T> Items, int TotalCount)> GetPagedListAsync(
            Expression<Func<T, bool>>? expression = null,
            int pageNumber = 1,
            int pageSize = 10,
            bool tracked = true,
            CancellationToken cancellationToken = default,
            params Expression<Func<T, object>>[] includes);

        /// <summary>
        /// Counts the total number of entities matching the given condition.
        /// </summary>
        Task<int> CountAsync(
            Expression<Func<T, bool>>? expression = null,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Checks whether any entity matches the given condition.
        /// </summary>
        Task<bool> ExistsAsync(
            Expression<Func<T, bool>>? expression = null,
            CancellationToken cancellationToken = default);
    }
}