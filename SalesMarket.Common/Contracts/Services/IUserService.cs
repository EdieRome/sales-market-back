using SalesMarket.Common.Dto.Request;
using SalesMarket.Common.Dto.Response;

namespace SalesMarket.Common.Contracts.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserResponse>> GetAllAsync();
        Task AddAsync(UserRequest user);
    }
}
