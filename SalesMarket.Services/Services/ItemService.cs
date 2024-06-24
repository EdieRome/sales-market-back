using AutoMapper;
using SalesMarket.Common.Contracts.Factories;
using SalesMarket.Common.Contracts.Services;
using SalesMarket.Common.Dto.Request;
using SalesMarket.Common.Dto.Response;
using SalesMarket.Common.Models;

namespace SalesMarket.Services.Services
{
    public class ItemService : BaseService, IItemService
    {
        public ItemService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        public async Task<IEnumerable<ItemResponse>> GetAllAsync() => await _unitOfWork.ItemRepository.GetAllAsync();

        public async Task<ItemResponse> GetByIdAsync(int id) => await _unitOfWork.ItemRepository.GetByIdAsync(id);

        public async Task AddAsync(ItemRequest item)
        {
            var entity = _mapper.Map<Item>(item);
            await _unitOfWork.ItemRepository.AddAsync(entity);
        }

        public async Task UpdateAsync(ItemRequest item)
        {
            var entity = _mapper.Map<Item>(item);
            await _unitOfWork.ItemRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id) => await _unitOfWork.ItemRepository.DeleteAsync(id);
    }
}
