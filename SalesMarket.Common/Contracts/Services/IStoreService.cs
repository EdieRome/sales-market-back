using SalesMarket.Common.Dto.Request;
using SalesMarket.Common.Dto.Response;

namespace SalesMarket.Common.Contracts.Services
{
    public interface IStoreService
    {
        Task<IEnumerable<StoreResponse>> GetAllAsync();
        Task<StoreResponse> GetByIdAsync(int id);
        Task AddAsync(StoreRequest store);
        Task UpdateAsync(StoreRequest store);
        Task DeleteAsync(int id);
    }
}
