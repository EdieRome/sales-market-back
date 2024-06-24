using AutoMapper;
using SalesMarket.Common.Contracts.Repositories;
using SalesMarket.Common.Dto.Response;
using SalesMarket.Common.Models;

namespace SalesMarket.Repositories.Repositories
{
    public class StoreRepository : BaseRepository<Store, StoreResponse>, IStoreRepository
    {
        public StoreRepository(DatabaseContext context, IMapper mapper) : base(context, mapper) { }
    }
}
