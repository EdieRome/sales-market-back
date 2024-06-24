using AutoMapper;
using SalesMarket.Common.Contracts.Repositories;
using SalesMarket.Common.Dto.Response;
using SalesMarket.Common.Models;

namespace SalesMarket.Repositories.Repositories
{
    public class CustomerItemRepository : BaseRepository<CustomerItem, CustomerItemResponse>, ICustomerItemRepository
    {
        public CustomerItemRepository(DatabaseContext context, IMapper mapper) : base(context, mapper) { }
    }
}
