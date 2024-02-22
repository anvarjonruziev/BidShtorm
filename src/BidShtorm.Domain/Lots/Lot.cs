using BidShtorm.Domain.Locations;

namespace BidShtorm.Domain.Lots
{
    public class Lot : BaseEntity
    {
        public string Number { get; set; }
        public Guid LocationId { get; set; }
        public Location Location { get; set; }
        public Guid LaneId { get; set; }
        public Lane Lane { get; set; }
    }
}
