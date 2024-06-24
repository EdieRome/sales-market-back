using SalesMarket.Common.Dto.Response;
using SalesMarket.Common.Models;

namespace SalesMarket.Common.Contracts.Repositories
{
    public interface IItemRepository
    {
        Task<IEnumerable<ItemResponse>> GetAllAsync();
        Task<ItemResponse> GetByIdAsync(int id);
        Task AddAsync(Item item);
        Task UpdateAsync(Item item);
        Task DeleteAsync(int id);
    }
}
