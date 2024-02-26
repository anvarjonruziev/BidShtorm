namespace BidShtorm.Domain.Lots
{
    public class LotImage : BaseEntity
    {
        public string Url { get; set; }
        public Guid LotId { get; set; }
        public Lot Lot { get; set; }
    }
}
