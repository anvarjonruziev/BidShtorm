using BidShtorm.Domain.Profiles;

namespace BidShtorm.Domain.Lots
{
    public class Bid : BaseEntity
    {
        public decimal Price { get; set; }
        public Guid BuyerId { get; set; }
        public Buyer Buyer { get; set; }
        public Guid LotId { get; set; }
        public Lot Lot { get; set; }
    }
}
