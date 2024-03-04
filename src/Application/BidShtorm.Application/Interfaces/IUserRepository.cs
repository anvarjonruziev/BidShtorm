using BidShtorm.Domain.Users;

namespace BidShtorm.Application.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<bool> ExistsByEmailAsync(string email);
        Task<User> GetByEmailAsync(string email);
    }
}
