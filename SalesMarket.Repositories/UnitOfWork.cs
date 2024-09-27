using AutoMapper;
using SalesMarket.Common.Contracts.Factories;
using SalesMarket.Common.Contracts.Repositories;
using SalesMarket.Repositories.Repositories;

namespace SalesMarket.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        
        private readonly IMapper _mapper;
        private ICustomerRepository? _customerRepository = null;
        private IItemRepository? _itemRepository = null;
        private IItemStoreRepository? _itemStoreRepository = null;
        private IStoreRepository? _storeRepository = null;
        private ICustomerItemRepository? _customerItemRepository = null;
        private IUserRepository? _userRepository = null;

        public UnitOfWork(DatabaseContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        public IItemRepository ItemRepository => _itemRepository ??= new ItemRepository(_context, _mapper);
        public ICustomerRepository CustomerRepository => _customerRepository ??= new CustomerRepository(_context, _mapper);
        public ICustomerItemRepository CustomerItemRepository => _customerItemRepository ??= new CustomerItemRepository(_context, _mapper);
        public IStoreRepository StoreRepository => _storeRepository ??= new StoreRepository(_context, _mapper);
        public IItemStoreRepository ItemStoreRepository => _itemStoreRepository ??= new ItemStoreRepository(_context, _mapper);
        public IUserRepository UserRepository => _userRepository ??= new UserRepository(_context, _mapper);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            // Cleanup
        }
    }
}
