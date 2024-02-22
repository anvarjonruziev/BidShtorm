using BidShtorm.Domain.Profiles;

namespace BidShtorm.Domain.Lots
{
    public class Winn:BaseEntity
    {
        public Guid LotId { get; set; }
        public Lot Lot { get; set; }
        public Guid BuyerId { get; set; }
        public Buyer Buyer { get; set; }
        public Guid BidId { get; set; }
        public Bid Bid { get; set; }
    }
}
