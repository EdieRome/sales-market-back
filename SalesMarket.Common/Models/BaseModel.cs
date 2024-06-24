using SalesMarket.Common.Contracts.Models;

namespace SalesMarket.Common.Models
{
    public abstract class BaseModel : Entity, IBaseModel
    {
        public string CreationUser { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModificationUser { get; set; }
        public DateTime ModificationDate { get; set; }
        public bool IsActive { get; set; }
    }
}
