namespace SalesMarket.Common.Dto.Request
{
    public class CustomerRequest : BaseRequest
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public ICollection<CustomerItemRequest> CustomerItems { get; set; }
    }
}
