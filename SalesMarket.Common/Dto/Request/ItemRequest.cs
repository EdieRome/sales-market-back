namespace SalesMarket.Common.Dto.Request
{
    public class ItemRequest : BaseRequest
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string UrlImage { get; set; }
        public int Stock { get; set; }

        public ICollection<ItemStoreRequest> ItemStores { get; set; }
        public ICollection<CustomerItemRequest> CustomerItems { get; set; }
    }
}
