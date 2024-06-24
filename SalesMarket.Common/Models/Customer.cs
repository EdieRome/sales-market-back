namespace SalesMarket.Common.Models
{
    public class Customer : BaseModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public ICollection<CustomerItem> CustomerItems { get; set; }
    }
}
