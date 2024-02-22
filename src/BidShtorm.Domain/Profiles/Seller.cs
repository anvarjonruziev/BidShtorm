using BidShtorm.Domain.Lots;
using BidShtorm.Domain.Profiles;

namespace BidShtorm.Domain.Sellers
{
    public class Seller : BaseProfile
    {
        public ICollection<Lot> Lots { get; set; }
    }
}
