namespace SalesMarket.Common.Models
{
    public class Store : BaseModel
    {
        public string BranchOffice { get; set; }
        public string Address { get; set; }

        public ICollection<ItemStore> ItemStores { get; set; }
    }
}
