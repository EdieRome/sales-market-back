using SalesMarket.Common.Dto.Response;
using SalesMarket.Common.Models;

namespace SalesMarket.Common.Contracts.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserResponse>> GetAllAsync();
        Task AddAsync(User user);
    }
}
