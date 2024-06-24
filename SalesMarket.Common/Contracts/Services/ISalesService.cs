using SalesMarket.Common.Dto.Request;
using SalesMarket.Common.Dto.Response;

namespace SalesMarket.Common.Contracts.Services
{
    public interface ISalesService
    {
        Task<IEnumerable<CustomerItemResponse>> GetAllAsync();
        Task<CustomerItemResponse> GetByIdAsync(int id);
        Task AddAsync(CustomerItemRequest customerItem);
        Task UpdateAsync(CustomerItemRequest customerItem);
        Task DeleteAsync(int id);
    }
}
