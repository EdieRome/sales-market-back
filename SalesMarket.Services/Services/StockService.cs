using AutoMapper;
using SalesMarket.Common.Contracts.Factories;
using SalesMarket.Common.Contracts.Services;
using SalesMarket.Common.Dto.Request;
using SalesMarket.Common.Dto.Response;
using SalesMarket.Common.Models;

namespace SalesMarket.Services.Services
{
    public class StockService : BaseService, IStockService
    {
        public StockService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        public async Task<IEnumerable<ItemStoreResponse>> GetAllAsync() => await _unitOfWork.ItemStoreRepository.GetAllAsync();

        public async Task<ItemStoreResponse> GetByIdAsync(int id) => await _unitOfWork.ItemStoreRepository.GetByIdAsync(id);

        public async Task AddAsync(ItemStoreRequest itemStore)
        {
            var entity = _mapper.Map<ItemStore>(itemStore);
            await _unitOfWork.ItemStoreRepository.AddAsync(entity);
        }

        public async Task UpdateAsync(ItemStoreRequest itemStore)
        {
            var entity = _mapper.Map<ItemStore>(itemStore);
            await _unitOfWork.ItemStoreRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id) => await _unitOfWork.ItemStoreRepository.DeleteAsync(id);
    }
}
