using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LibrarySystem.Common.Repositories
{
    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> GetQueryable();

        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        void SoftDelete(TEntity entity);

        Task<TEntity?> GetByIdAsync(int id);
        Task<TEntity?> GetFirstAsync(Expression<Func<TEntity, bool>> predicate);

        Task SaveAsync();
    }


}
