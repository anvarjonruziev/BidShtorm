using BidShtorm.Domain.Locations;

namespace BidShtorm.Domain.Profiles
{
    public class Owner: BaseProfile
    {
        public Guid LocationId { get; set; }
        public Location Location { get; set; }
    }
}
