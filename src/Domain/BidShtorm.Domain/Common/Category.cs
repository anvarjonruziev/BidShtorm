namespace BidShtorm.Domain.Common
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public Guid? ParentId { get; set; }
        public Category Parent { get; set; }
    }
}
