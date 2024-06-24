using AutoMapper;
using SalesMarket.Common.Contracts.Factories;
using SalesMarket.Common.Contracts.Services;
using SalesMarket.Common.Dto.Request;
using SalesMarket.Common.Dto.Response;
using SalesMarket.Common.Models;

namespace SalesMarket.Services.Services
{
    public class CustomerService : BaseService, ICustomerService
    {
        public CustomerService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        public async Task<IEnumerable<CustomerResponse>> GetAllAsync() => await _unitOfWork.CustomerRepository.GetAllAsync();

        public async Task<CustomerResponse> GetByIdAsync(int id) => await _unitOfWork.CustomerRepository.GetByIdAsync(id);

        public async Task AddAsync(CustomerRequest customer)
        {
            var entity = _mapper.Map<Customer>(customer);
            await _unitOfWork.CustomerRepository.AddAsync(entity);
        }

        public async Task UpdateAsync(CustomerRequest customer)
        {
            var entity = _mapper.Map<Customer>(customer);
            await _unitOfWork.CustomerRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id) => await _unitOfWork.CustomerRepository.DeleteAsync(id);
    }
}
