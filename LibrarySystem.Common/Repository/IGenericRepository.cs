using System.Linq.Expressions;

namespace LibrarySystem.Domain.Repositories.IRepo
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T?> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();

        Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate);

        Task<List<T>> FindAsync(
            Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IQueryable<T>> include
        );

        IQueryable<T> GetQueryable();

        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task SoftDeleteAsync(T entity);

    }
}
