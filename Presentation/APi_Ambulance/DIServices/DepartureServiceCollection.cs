using APi_Ambulance.Domain.DTO.DtoCallDepartrure;
using APi_Ambulance.Domain.Entity;
using APi_Ambulance.Persistens.Repository.Implementations;
using APi_Ambulance.Persistens.Repository.Interfaces.Repo;
using API_Ambulance.Application.GenericInterfaces;
using API_Ambulance.Application.Implementation;
using System.Runtime.CompilerServices;

namespace APi_Ambulance.DIServices
{
    public static class DepartureServiceCollection
    {
        public static IServiceCollection AddDepartureService(
            this IServiceCollection services)
        {
            services.AddScoped<IRepository<AmbulanceDeparture>, EmplementationDepart>();
            services.AddScoped<IBizServices<AmbulanceDepartureDto>, BizServiceDepart>();
            
            return services;
        }
    }
}
