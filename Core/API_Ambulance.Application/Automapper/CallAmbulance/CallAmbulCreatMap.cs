using APi_Ambulance.Domain.DTO.DToCallAmbul;
using APi_Ambulance.Domain.Entity;
using AutoMapper;


namespace API_Ambulance.Application.Automapper.CallAmbulance
{
    public class CallAmbulCreatMap : Profile
    {
        public CallAmbulCreatMap()
        {
            CreateMap<CreateCallAmbulDto, CallingAmbulance>();
        }
    }
}
