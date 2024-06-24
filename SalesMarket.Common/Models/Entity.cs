using SalesMarket.Common.Contracts.Models;
using System.ComponentModel.DataAnnotations;

namespace SalesMarket.Common.Models
{
    public abstract class Entity : IEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
