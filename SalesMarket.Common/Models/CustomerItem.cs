namespace SalesMarket.Common.Models
{
    public class CustomerItem : BaseModel
    {
        public int IdCustomer { get; set; }
        public int IdItem { get; set; }
        public DateTime Date { get; set; }

        public Customer Customer { get; set; }
        public Item Item { get; set; }
    }
}
