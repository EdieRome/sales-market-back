using SalesMarket.Common.Dto.Request;
using SalesMarket.Common.Dto.Response;

namespace SalesMarket.Common.Contracts.Services
{
    public interface IStockService
    {
        Task<IEnumerable<ItemStoreResponse>> GetAllAsync();
        Task<ItemStoreResponse> GetByIdAsync(int id);
        Task AddAsync(ItemStoreRequest itemStore);
        Task UpdateAsync(ItemStoreRequest itemStore);
        Task DeleteAsync(int id);
    }
}
