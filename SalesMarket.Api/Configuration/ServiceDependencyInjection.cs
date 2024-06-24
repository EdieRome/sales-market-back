using AutoMapper;
using SalesMarket.Common.Automap;
using SalesMarket.Common.Contracts.Factories;
using SalesMarket.Common.Contracts.Repositories;
using SalesMarket.Repositories;
using SalesMarket.Repositories.Repositories;
using SalesMarket.Services;

namespace SalesMarket.Api.Configuration
{
    public static class ServiceDependencyInjection
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IServicesCore, ServicesCore>();

            var mapperConfig = new MapperConfiguration(mc => mc.AddProfile<DtoToDtoAutoMapping>());
            var mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}
