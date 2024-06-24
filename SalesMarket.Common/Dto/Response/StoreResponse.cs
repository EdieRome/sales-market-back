namespace SalesMarket.Common.Dto.Response
{
    public class StoreResponse : BaseResponse
    {
        public string BranchOffice { get; set; }
        public string Address { get; set; }

        public ICollection<ItemStoreResponse> ItemStores { get; set; }
    }
}
