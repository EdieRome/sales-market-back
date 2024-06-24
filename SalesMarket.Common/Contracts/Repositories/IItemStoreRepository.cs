using SalesMarket.Common.Dto.Response;
using SalesMarket.Common.Models;

namespace SalesMarket.Common.Contracts.Repositories
{
    public interface IItemStoreRepository
    {
        Task<IEnumerable<ItemStoreResponse>> GetAllAsync();
        Task<ItemStoreResponse> GetByIdAsync(int id);
        Task AddAsync(ItemStore itemStore);
        Task UpdateAsync(ItemStore itemStore);
        Task DeleteAsync(int id);
    }
}
