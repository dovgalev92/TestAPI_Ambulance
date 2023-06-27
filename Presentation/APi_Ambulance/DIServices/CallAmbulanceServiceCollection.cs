using APi_Ambulance.Domain.DTO.DToCallAmbul;
using APi_Ambulance.Domain.Entity;
using APi_Ambulance.Persistens.Repository.Implementations;
using APi_Ambulance.Persistens.Repository.Interfaces.Repo;
using API_Ambulance.Application.GenericInterfaces;
using API_Ambulance.Application.Implementation;

namespace APi_Ambulance.DIServices
{
    public static class CallAmbulanceServiceCollection
    {
        public static IServiceCollection AddCallAmbulanceServices(
            this IServiceCollection services)
        {
            services.AddScoped<IRepository<CallingAmbulance>, EmplementationRepository>();
            services.AddScoped<IBizServices<CreateCallAmbulDto>, BizServices>();

            return services;
        }
    }
}
