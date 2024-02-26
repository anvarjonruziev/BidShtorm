using BidShtorm.Domain.Locations;
using BidShtorm.Domain.Sellers;

namespace BidShtorm.Domain.Lots
{
    public class Lot : BaseEntity
    {
        public string Description { get; set; }
        public int LaneOrder { get; set; }
        public DateTime PrebidStartDate { get; set; }
        public DateTime PrebidEndDate { get; set; }
        public DateTime LiveDate { get; set; }
        public decimal CurrentPrice { get; set; }
        public Guid SellerId { get; set; }
        public Seller Seller { get; set; }
        public string Number { get; set; }
        public Guid LocationId { get; set; }
        public Location Location { get; set; }
        public Guid LaneId { get; set; }
        public Lane Lane { get; set; }
        public Guid? LastBidId { get; set; }
        public Bid LastBid { get; set; }
        public Guid? WinnId { get; set; }
        public Winn Winn { get; set; }
    }
}
