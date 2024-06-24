using SalesMarket.Common.Dto.Response;
using SalesMarket.Common.Models;

namespace SalesMarket.Common.Contracts.Repositories
{
    public interface IStoreRepository
    {
        Task<IEnumerable<StoreResponse>> GetAllAsync();
        Task<StoreResponse> GetByIdAsync(int id);
        Task AddAsync(Store store);
        Task UpdateAsync(Store store);
        Task DeleteAsync(int id);
    }
}
