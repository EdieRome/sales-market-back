using SalesMarket.Common.Dto.Response;
using SalesMarket.Common.Models;

namespace SalesMarket.Common.Contracts.Repositories
{
    public interface ICustomerItemRepository
    {
        Task<IEnumerable<CustomerItemResponse>> GetAllAsync();
        Task<CustomerItemResponse> GetByIdAsync(int id);
        Task AddAsync(CustomerItem customer);
        Task UpdateAsync(CustomerItem customer);
        Task DeleteAsync(int id);
    }
}
