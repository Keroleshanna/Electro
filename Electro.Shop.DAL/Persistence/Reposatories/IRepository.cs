using System.Linq.Expressions;

namespace Electro.Shop.DAL.Persistence.Reposatories
{
    // ده المخزن العام (Generic Repository) اللي بيحتوي على العمليات العامة لأي كيان (entity):
    public interface IRepository<T> where T : class
    {
        void Update(T entity);

        void Delete(T entity);

        Task<T> CreateAsync(T entity, CancellationToken cancellationToken = default);

        Task<IEnumerable<T>> GetAllAsync(
            Expression<Func<T, bool>>? expression = null,
            Expression<Func<T, object>>[]? includes = null,
            bool tracked = true,
            CancellationToken cancellationToken = default
            );

        Task<T?> GetOneAsync(
            Expression<Func<T, bool>>? expression = null,
            Expression<Func<T, object>>[]? Includes = null,
            bool tracked = true,
            CancellationToken cancellationToken = default
            );

        // Task<(IEnumerable<T> Items, int TotalCount)> GetPagedAsync(
        // Expression<Func<T, bool>>? expression = null,
        // Expression<Func<T, object>>[]? includes = null,
        // int pageNumber = 1,
        // int pageSize = 10,
        // Expression<Func<T, object>>? orderBy = null,
        // bool ascending = true,
        // bool tracked = false,
        // CancellationToken cancellationToken = default);
    }
}
