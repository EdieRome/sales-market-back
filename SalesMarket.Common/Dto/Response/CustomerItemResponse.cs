namespace SalesMarket.Common.Dto.Response
{
    public class CustomerItemResponse : BaseResponse
    {
        public int IdCustomer { get; set; }
        public int IdItem { get; set; }
        public DateTime Date { get; set; }

        public CustomerResponse Customer { get; set; }
        public ItemResponse Item { get; set; }
    }
}
