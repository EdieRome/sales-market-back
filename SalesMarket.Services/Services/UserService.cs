using AutoMapper;
using SalesMarket.Common.Contracts.Factories;
using SalesMarket.Common.Contracts.Services;
using SalesMarket.Common.Dto.Request;
using SalesMarket.Common.Dto.Response;
using SalesMarket.Common.Models;

namespace SalesMarket.Services.Services
{
    public class UserService : BaseService, IUserService
    {
        public UserService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        public async Task<IEnumerable<UserResponse>> GetAllAsync() => await _unitOfWork.UserRepository.GetAllAsync();
        public async Task AddAsync(UserRequest user)
        {
            var entity = _mapper.Map<User>(user);
            entity.Id = 0;
            entity.CreationUser = string.Empty;
            entity.CreationDate = DateTime.Now;
            entity.ModificationUser = string.Empty;
            entity.ModificationDate = DateTime.Now;
            entity.IsActive = true;
            await _unitOfWork.UserRepository.AddAsync(entity);
        }
    }
}
