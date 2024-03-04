using BidShtorm.Application.Interfaces;
using BidShtorm.Domain.Users;
using BidShtorm.Infrastructure.Common.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BidShtorm.Infrastructure
{
    public class UserRepository(BidShtormDbContext dbContext) : BaseRepository<User>(dbContext), IUserRepository
    {
        object locker = new object();
        public Task<bool> ExistsByEmailAsync(string email)
            => _dbContext.Users.AnyAsync(u => u.Email == email);

        public Task<User> GetByEmailAsync(string email)
            => _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
    }
}