using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LibrarySystem.Common.Repositories
{
    public class Repository<TDbContext, TEntity> : IRepository<TEntity>
      where TEntity : class
      where TDbContext : DbContext
    {
        protected readonly TDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public Repository(TDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetQueryable() => _dbSet;

        public async Task AddAsync(TEntity entity) => await _dbSet.AddAsync(entity);
        public Task UpdateAsync(TEntity entity) { _dbSet.Update(entity); return Task.CompletedTask; }
        public void SoftDelete(TEntity entity) => _dbSet.Remove(entity);

        public Task<TEntity?> GetByIdAsync(int id) => _dbSet.FindAsync(id).AsTask();
        public Task<TEntity?> GetFirstAsync(Expression<Func<TEntity, bool>> p) => _dbSet.FirstOrDefaultAsync(p);

        public Task SaveAsync() => _context.SaveChangesAsync();
    }

}


