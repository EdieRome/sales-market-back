using AutoMapper;
using SalesMarket.Common.Contracts.Repositories;
using SalesMarket.Common.Dto.Response;
using SalesMarket.Common.Models;

namespace SalesMarket.Repositories.Repositories
{
    public class CustomerRepository : BaseRepository<Customer, CustomerResponse>, ICustomerRepository
    {
        public CustomerRepository(DatabaseContext context, IMapper mapper) : base(context, mapper) { }
    }
}
