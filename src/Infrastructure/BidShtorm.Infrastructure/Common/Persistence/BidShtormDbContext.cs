using BidShtorm.Application.Interfaces;
using BidShtorm.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace BidShtorm.Infrastructure.Common.Persistence
{
    public class BidShtormDbContext(DbContextOptions options) : DbContext(options), IUnitOfWork
    {
        public DbSet<User> Users { get; set; }

        public async Task CommitChangesAsync()
        {
            await SaveChangesAsync();
        }
    }
}
