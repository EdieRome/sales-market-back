namespace SalesMarket.Common.Dto.Response
{
    public class ItemResponse : BaseResponse
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string UrlImage { get; set; }
        public int Stock { get; set; }

        public ICollection<ItemStoreResponse> ItemStores { get; set; }
        public ICollection<CustomerItemResponse> CustomerItems { get; set; }
    }
}
