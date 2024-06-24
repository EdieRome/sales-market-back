using SalesMarket.Common.Contracts.Repositories;

namespace SalesMarket.Common.Contracts.Factories
{
    public interface IUnitOfWork : IDisposable
    {
        public ICustomerRepository CustomerRepository { get; }
        public IItemRepository ItemRepository { get; }
        public ICustomerItemRepository CustomerItemRepository { get; }
        public IStoreRepository StoreRepository { get; }
        public IItemStoreRepository ItemStoreRepository { get; }
    }
}
