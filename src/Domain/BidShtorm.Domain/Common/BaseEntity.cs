namespace BidShtorm.Domain
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime RecordDate { get; } = DateTime.Now;
    }
}
