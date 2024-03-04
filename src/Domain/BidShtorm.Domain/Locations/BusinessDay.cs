using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BidShtorm.Domain.Locations
{
    public class BusinessDay: BaseEntity
    {
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }
        public Guid LocationId { get; set; }
        public Location Location { get; set; }
    }
}
