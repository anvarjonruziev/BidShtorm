using BidShtorm.Application.Interfaces;

namespace BidShtorm.Infrastructure.Common.Persistence
{
    public class BaseRepository<TEntity>(BidShtormDbContext dbContext) : IBaseRepository<TEntity> where TEntity : class
    {
        public readonly BidShtormDbContext _dbContext = dbContext;
        public async Task AddAsync(TEntity entity)
            => await _dbContext.AddAsync(entity);

        public async Task<TEntity> GetByIdAsync(Guid id)
            => await _dbContext.FindAsync<TEntity>(id);

        public void Update(TEntity entity)
            => _dbContext.Update(entity);
    }
}
