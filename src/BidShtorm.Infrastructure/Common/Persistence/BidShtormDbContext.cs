using BidShtorm.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace BidShtorm.Infrastructure.Common.Persistence
{
    public class BidShtormDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
