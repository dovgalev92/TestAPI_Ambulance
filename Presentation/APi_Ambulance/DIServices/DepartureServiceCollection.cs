using APi_Ambulance.Domain.DTO.DtoCallDepartrure;
using APi_Ambulance.Domain.Entity;
using APi_Ambulance.Persistens.Repository.Implementations;
using APi_Ambulance.Persistens.Repository.Interfaces.GenericRepository;
using API_Ambulance.Application.GenericInterfaces;
using API_Ambulance.Application.Implementation;

namespace APi_Ambulance.DIServices
{
    public static class DepartureServiceCollection
    {
        public static IServiceCollection AddDepartureService(
            this IServiceCollection services)
        {
            services.AddScoped<IRepository<AmbulanceDeparture>,EmplementationDeparture>();
            services.AddScoped<IBizServices<CreateAmbulanceDepartureDto>, BizServicesDepart>();
            
            return services;
        }
    }
}
