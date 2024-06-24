using SalesMarket.Common.Dto.Request;
using SalesMarket.Common.Dto.Response;

namespace SalesMarket.Common.Contracts.Services
{
    public interface IItemService
    {
        Task<IEnumerable<ItemResponse>> GetAllAsync();
        Task<ItemResponse> GetByIdAsync(int id);
        Task AddAsync(ItemRequest item);
        Task UpdateAsync(ItemRequest item);
        Task DeleteAsync(int id);
    }
}
