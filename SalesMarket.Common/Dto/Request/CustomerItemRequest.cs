namespace SalesMarket.Common.Dto.Request
{
    public class CustomerItemRequest : BaseRequest
    {
        public int IdCustomer { get; set; }
        public int IdItem { get; set; }
        public DateTime Date { get; set; }

        public CustomerRequest Customer { get; set; }
        public ItemRequest Item { get; set; }
    }
}
