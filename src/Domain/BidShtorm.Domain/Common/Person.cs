namespace BidShtorm.Domain.Common
{
    public abstract class Person: BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string ProfilePhoto { get; set; }
    }
}
