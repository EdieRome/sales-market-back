using AutoMapper;
using SalesMarket.Common.Contracts.Repositories;
using SalesMarket.Common.Dto.Response;
using SalesMarket.Common.Models;

namespace SalesMarket.Repositories.Repositories
{
    public class UserRepository : BaseRepository<User, UserResponse>, IUserRepository
    {
        public UserRepository(DatabaseContext context, IMapper mapper) : base(context, mapper) { }
    }
}
