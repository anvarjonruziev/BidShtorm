using BidShtorm.Domain.Lots;

namespace BidShtorm.Domain.Locations
{
    public class Location: BaseEntity
    {
        public string Name { get; set; }
        public string PhysicalAddress { get; set; }
        public string MailingAddress { get; set; }
        public TimeSpan TimeZone { get; set; } = TimeSpan.Zero;
        public string Phone { get; set; }
        public string Email { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public ICollection<Lot> Lots { get; set; }
        public ICollection<BusinessDay> BusinessDays { get; set; }
    }
}
