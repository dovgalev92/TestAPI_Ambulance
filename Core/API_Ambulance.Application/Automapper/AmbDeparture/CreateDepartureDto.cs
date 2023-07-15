using APi_Ambulance.Domain.Entity;
using AutoMapper;
using APi_Ambulance.Domain.DTO.DtoCallDepartrure;


namespace API_Ambulance.Application.Automapper.AmbDeparture
{
    public class CreateDepartureDto : Profile
    {
        public CreateDepartureDto()
        {
            CreateMap<CreateAmbulanceDepartureDto, AmbulanceDeparture>();
        }
    }
}
