using AutoMapper;
using SalesMarket.Common.Contracts.Factories;
using SalesMarket.Common.Contracts.Services;
using SalesMarket.Common.Dto.Request;
using SalesMarket.Common.Dto.Response;
using SalesMarket.Common.Models;

namespace SalesMarket.Services.Services
{
    public class SalesService : BaseService, ISalesService
    {
        public SalesService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        public async Task<IEnumerable<CustomerItemResponse>> GetAllAsync() => await _unitOfWork.CustomerItemRepository.GetAllAsync();

        public async Task<CustomerItemResponse> GetByIdAsync(int id) => await _unitOfWork.CustomerItemRepository.GetByIdAsync(id);

        public async Task AddAsync(CustomerItemRequest customerItem)
        {
            var entity = _mapper.Map<CustomerItem>(customerItem);
            await _unitOfWork.CustomerItemRepository.AddAsync(entity);
        }

        public async Task UpdateAsync(CustomerItemRequest customerItem)
        {
            var entity = _mapper.Map<CustomerItem>(customerItem);
            await _unitOfWork.CustomerItemRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id) => await _unitOfWork.CustomerItemRepository.DeleteAsync(id);
    }
}
