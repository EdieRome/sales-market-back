namespace SalesMarket.Common.Dto.Response
{
    public class CustomerResponse : BaseResponse
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public ICollection<CustomerItemResponse> CustomerItems { get; set; }
    }
}
