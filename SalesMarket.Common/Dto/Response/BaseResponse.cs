namespace SalesMarket.Common.Dto.Response
{
    public class BaseResponse
    {
        public int Id { get; set; }
        public string CreationUser { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModificationUser { get; set; }
        public DateTime ModificationDate { get; set; }
        public bool IsActive { get; set; }
    }
}
