using APi_Ambulance.Domain.DTO.DTOPatient;
using APi_Ambulance.Domain.Entity;
using AutoMapper;


namespace API_Ambulance.Application.Automapper.Patients
{
    public class UpdateMapPatient : Profile
    {
        public UpdateMapPatient() 
        {
            CreateMap<PatientUpdateDto, Patient>();
        }
    }
}
