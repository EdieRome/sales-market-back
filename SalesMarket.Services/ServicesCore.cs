using AutoMapper;
using SalesMarket.Common.Contracts.Factories;
using SalesMarket.Common.Contracts.Services;
using SalesMarket.Services.Services;

namespace SalesMarket.Services
{
    public class ServicesCore : IServicesCore
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        private ICustomerService? _customerService = null;
        private IItemService? _itemService = null;
        private ISalesService? _salesService = null;
        private IStockService? _stockService = null;
        private IStoreService? _storeService = null;

        public ServicesCore(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
        }

        public ICustomerService CustomerService => _customerService ??= new CustomerService(_unitOfWork, _mapper);

        public IItemService ItemService => _itemService ??= new ItemService(_unitOfWork, _mapper);

        public ISalesService SalesService => _salesService ??= new SalesService(_unitOfWork, _mapper);

        public IStockService StockService => _stockService ??= new StockService(_unitOfWork, _mapper);

        public IStoreService StoreService => _storeService ??= new StoreService(_unitOfWork, _mapper);
    }
}
