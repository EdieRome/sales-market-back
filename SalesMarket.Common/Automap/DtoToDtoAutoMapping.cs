using AutoMapper;
using SalesMarket.Common.Dto.Request;
using SalesMarket.Common.Dto.Response;
using SalesMarket.Common.Models;

namespace SalesMarket.Common.Automap
{
    public class DtoToDtoAutoMapping : Profile
    {
        public DtoToDtoAutoMapping()
        {
            CreateMap<Customer, CustomerResponse>().ReverseMap();
            CreateMap<CustomerItem, CustomerItemResponse>().ReverseMap();
            CreateMap<Item, ItemResponse>().ReverseMap();
            CreateMap<ItemStore, ItemStoreResponse>().ReverseMap();
            CreateMap<Store, StoreResponse>().ReverseMap();

            CreateMap<Customer, CustomerRequest>().ReverseMap();
            CreateMap<CustomerItem, CustomerItemRequest>().ReverseMap();
            CreateMap<Item, ItemRequest>().ReverseMap();
            CreateMap<ItemStore, ItemStoreRequest>().ReverseMap();
            CreateMap<Store, StoreRequest>().ReverseMap();
        }
    }
}
