using BidShtorm.Domain.Common;
using BidShtorm.Domain.Profiles;
using BidShtorm.Domain.Sellers;

namespace BidShtorm.Domain.Users
{
    public class User : Person
    {
        public string PasswordHash { get; set; }
        public Guid? SellerId { get; set; }
        public Seller Seller { get; set; }
        public Guid? BuyerId { get; set; }
        public Buyer Buyer { get; set; }
        public Guid? OwnerId { get; set; }
        public Owner Owner { get; set; }

    }
}
