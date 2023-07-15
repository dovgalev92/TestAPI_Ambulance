using APi_Ambulance.Domain.DTO.DToPatient;
using APi_Ambulance.Domain.Entity;
using APi_Ambulance.Persistens.Repository.Implementations;
using APi_Ambulance.Persistens.Repository.Interfaces.Patient;
using API_Ambulance.Application.GenericInterfaces;
using API_Ambulance.Application.Implementation;

namespace APi_Ambulance.DIServices
{
    public static class PatientServiceCollection
    {
        public static IServiceCollection AddPatientServices(
            this IServiceCollection services)
        {
            services.AddScoped<IRepositoryPatient<Patient>, EmplementationRepositoryPatient>();
            services.AddScoped<IBizServicesPatient<PatientWriteDto, PatientReadDto>, BizServicesPatient>();

            return services;
        }
    }
}
