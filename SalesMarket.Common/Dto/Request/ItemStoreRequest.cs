namespace SalesMarket.Common.Dto.Request
{
    public class ItemStoreRequest : BaseRequest
    {
        public int IdItem { get; set; }
        public int IdStore { get; set; }
        public DateTime Date { get; set; }

        public ItemRequest Item { get; set; }
        public StoreRequest Store { get; set; }
    }
}
