namespace BidShtorm.Domain
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; } = DateTime.Now;
    }
}
