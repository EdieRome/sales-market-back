using AutoMapper;
using SalesMarket.Common.Contracts.Factories;

namespace SalesMarket.Services.Services
{
    public class BaseService
    {
        public readonly IMapper _mapper;
        public readonly IUnitOfWork _unitOfWork;

        public BaseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
        }
    }
}
