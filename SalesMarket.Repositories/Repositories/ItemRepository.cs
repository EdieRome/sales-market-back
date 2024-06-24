using AutoMapper;
using SalesMarket.Common.Contracts.Repositories;
using SalesMarket.Common.Dto.Response;
using SalesMarket.Common.Models;

namespace SalesMarket.Repositories.Repositories
{
    public class ItemRepository : BaseRepository<Item, ItemResponse>, IItemRepository
    {
        public ItemRepository(DatabaseContext context, IMapper mapper) : base(context, mapper) { }
    }
}
