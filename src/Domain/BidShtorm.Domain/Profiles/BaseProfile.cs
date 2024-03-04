using BidShtorm.Domain.Users;

namespace BidShtorm.Domain.Profiles
{
    public abstract class BaseProfile : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
