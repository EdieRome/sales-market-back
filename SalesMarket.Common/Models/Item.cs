namespace SalesMarket.Common.Models
{
    public class Item : BaseModel
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string UrlImage { get; set; }
        public int Stock { get; set; }

        public ICollection<ItemStore> ItemStores { get; set; }
        public ICollection<CustomerItem> CustomerItems { get; set; }
    }
}
