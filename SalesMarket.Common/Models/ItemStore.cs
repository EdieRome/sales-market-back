namespace SalesMarket.Common.Models
{
    public class ItemStore : BaseModel
    {
        public int IdItem { get; set; }
        public int IdStore { get; set; }
        public DateTime Date { get; set; }

        public Item Item { get; set; }
        public Store Store { get; set; }
    }
}
