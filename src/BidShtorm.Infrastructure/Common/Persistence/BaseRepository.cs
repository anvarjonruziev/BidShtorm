using BidShtorm.Application.Interfaces;

namespace BidShtorm.Infrastructure.Common.Persistence
{
    public class BaseRepository<TEntity>(BidShtormDbContext dbContext) : IBaseRepository<TEntity> where TEntity : class
    {
        public readonly BidShtormDbContext _dbContext = dbContext;
        public async Task AddAsync(TEntity entity)
        {
            await dbContext.AddAsync(entity);
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await dbContext.FindAsync<TEntity>(id);
        }

        public void Update(TEntity entity)
        {
            dbContext.Update(entity);
        }
    }
}
