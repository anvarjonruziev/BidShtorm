using BidShtorm.Domain;

namespace BidShtorm.Application.Interfaces
{
    public interface IBaseRepository<TEntity>
    {
        Task<TEntity> GetByIdAsync(Guid id);
        Task AddAsync(TEntity entity);
        Update(TEntity entity);
    }
}