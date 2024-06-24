using AutoMapper;
using SalesMarket.Common.Contracts.Repositories;
using SalesMarket.Common.Dto.Response;
using SalesMarket.Common.Models;

namespace SalesMarket.Repositories.Repositories
{
    public class ItemStoreRepository : BaseRepository<ItemStore, ItemStoreResponse>, IItemStoreRepository
    {
        public ItemStoreRepository(DatabaseContext context, IMapper mapper) : base(context, mapper) { }
    }
}
