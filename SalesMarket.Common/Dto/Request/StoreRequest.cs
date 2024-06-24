namespace SalesMarket.Common.Dto.Request
{
    public class StoreRequest : BaseRequest
    {
        public string BranchOffice { get; set; }
        public string Address { get; set; }

        public ICollection<ItemStoreRequest> ItemStores { get; set; }
    }
}
