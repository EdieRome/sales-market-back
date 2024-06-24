using AutoMapper;
using SalesMarket.Common.Contracts.Factories;
using SalesMarket.Common.Contracts.Services;
using SalesMarket.Common.Dto.Request;
using SalesMarket.Common.Dto.Response;
using SalesMarket.Common.Models;

namespace SalesMarket.Services.Services
{
    public class StoreService : BaseService, IStoreService
    {
        public StoreService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        public async Task<IEnumerable<StoreResponse>> GetAllAsync() => await _unitOfWork.StoreRepository.GetAllAsync();

        public async Task<StoreResponse> GetByIdAsync(int id) => await _unitOfWork.StoreRepository.GetByIdAsync(id);

        public async Task AddAsync(StoreRequest store)
        {
            var entity = _mapper.Map<Store>(store);
            await _unitOfWork.StoreRepository.AddAsync(entity);
        }

        public async Task UpdateAsync(StoreRequest store)
        {
            var entity = _mapper.Map<Store>(store);
            await _unitOfWork.StoreRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id) => await _unitOfWork.StoreRepository.DeleteAsync(id);
    }
}
