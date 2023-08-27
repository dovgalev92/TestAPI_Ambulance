using APi_Ambulance.Domain.DTO.DToPatient;
using APi_Ambulance.Domain.DTO.DTOPatient;
using StatusGeneric;

namespace APi_Ambulance.Persistens.Repository.Interfaces.Patient
{
    public interface IRepositoryPatient<T>
    {
        Task AddNewCommandAsync(T create);
        Task<IEnumerable<T>> GetAllCommandAsync();
        Task<T> GetCommandIdAsync(int id);
        Task<IStatusGeneric> UpdateCommandAsync(T update);
        Task<ActionSearchPatientDto> GetSearchPatient(PatientFilter filter);
    }
}
