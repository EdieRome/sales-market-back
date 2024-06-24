using SalesMarket.Common.Dto.Request;
using SalesMarket.Common.Dto.Response;

namespace SalesMarket.Common.Contracts.Services
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerResponse>> GetAllAsync();
        Task<CustomerResponse> GetByIdAsync(int id);
        Task AddAsync(CustomerRequest customer);
        Task UpdateAsync(CustomerRequest customer);
        Task DeleteAsync(int id);
    }
}
