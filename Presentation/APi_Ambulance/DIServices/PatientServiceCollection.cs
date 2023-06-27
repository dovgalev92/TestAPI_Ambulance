using APi_Ambulance.Domain.DTO.DTOPatient;
using APi_Ambulance.Domain.Entity;
using APi_Ambulance.Persistens.Repository.Implementations;
using APi_Ambulance.Persistens.Repository.Interfaces.Patient;
using API_Ambulance.Application.GenericInterfaces;
using API_Ambulance.Application.Implementation;
using System.Runtime.CompilerServices;

namespace APi_Ambulance.DIServices
{
    public static class PatientServiceCollection
    {
        public static IServiceCollection AddPatientServices(
            this IServiceCollection services)
        {
            services.AddScoped<IRepositoryPatient<Patient>, EmplementationRepositoryPatient>();
            services.AddScoped<IBizServicesPatient<PatientWriteDto, Patient>, BizServicesPatient>();

            return services;
        }
    }
}
