namespace SalesMarket.Common.Contracts.Models
{
    public interface IBaseModel
    {
        string CreationUser { get; set; }
        DateTime CreationDate { get; set; }
        string ModificationUser { get; set; }
        DateTime ModificationDate { get; set; }
        bool IsActive { get; set; }
    }
}
