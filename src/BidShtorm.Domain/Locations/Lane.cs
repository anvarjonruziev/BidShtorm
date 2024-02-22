using BidShtorm.Domain.Lots;

namespace BidShtorm.Domain.Locations
{
    public class Lane : BaseEntity
    {
        public string Name { get; set; }
        public Guid LocationId { get; set; }
        public Location Location { get; set; }
        public ICollection<Lot> Lots { get; set; }
    }
}
