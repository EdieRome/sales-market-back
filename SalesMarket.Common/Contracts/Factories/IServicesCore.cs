using SalesMarket.Common.Contracts.Services;

namespace SalesMarket.Common.Contracts.Factories
{
    public interface IServicesCore
    {
        ICustomerService CustomerService { get; }
        IItemService ItemService { get; }
        ISalesService SalesService { get; }
        IStockService StockService { get; }
        IStoreService StoreService { get; }
        IUserService UserService { get; }
    }
}
