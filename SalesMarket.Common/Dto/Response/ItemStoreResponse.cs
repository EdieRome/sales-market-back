namespace SalesMarket.Common.Dto.Response
{
    public class ItemStoreResponse : BaseResponse
    {
        public int IdItem { get; set; }
        public int IdStore { get; set; }
        public DateTime Date { get; set; }

        public ItemResponse Item { get; set; }
        public StoreResponse Store { get; set; }
    }
}
