using APi_Ambulance.Domain.DTO.DToCallAmbul;
using APi_Ambulance.Domain.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Ambulance.Application.Automapper.CallAmbulance
{
    public class CallAmbulanceReadMap : Profile
    {
        public CallAmbulanceReadMap()
        {
            CreateMap<CallingAmbulance, ReadCallAmbualnceDto>()
                .ForMember(p => p.Name, m => m.MapFrom(m => m.Patient.Name))
                .ForMember(p => p.Family_Name, m => m.MapFrom(m => m.Patient.Family_Name))
                .ForMember(p => p.Patronymic, m => m.MapFrom(m => m.Patient.Patronymic))
                .ForMember(d => d.NumberAccident_AssistantSquad, m => m.MapFrom(m => m.Departure.NumberAccident_AssistantSquad))
                .ForMember(d => d.DateDepart, m => m.MapFrom(m => m.Departure.DateDepart))
                .ForMember(d => d.TimeDepart, m => m.MapFrom(m => m.Departure.TimeDepart))
                .ForMember(d => d.StartPatient, m => m.MapFrom(m => m.Departure.StartPatient))
                .ForMember(d => d.EndTimePatient, m => m.MapFrom(m => m.Departure.EndTimePatient))
                .ForMember(d => d.NameHospital, m => m.MapFrom(m => m.Departure.NameHospital))
                .ForMember(d => d.Priority, m => m.MapFrom(m => m.Departure.Priority))
                .ForMember(d => d.ResultDepart, m => m.MapFrom(m => m.Departure.ResultDepart));
        }
    }
}
