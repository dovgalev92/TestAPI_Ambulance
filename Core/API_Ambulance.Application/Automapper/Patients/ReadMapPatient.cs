using APi_Ambulance.Domain.DTO.DToPatient;
using APi_Ambulance.Domain.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Ambulance.Application.Automapper.Patients
{
    public class ReadMapPatient : Profile
    {
        public ReadMapPatient() 
        {
            CreateMap<Patient, PatientReadDto>()
                .ForMember(l => l.NameLocality, m => m.MapFrom(m => m.Locality.NameLocality))
                .ForMember(s => s.NameStreet, m => m.MapFrom(m => m.Street.Name))
                .ForMember(s => s.NumberHouse, m => m.MapFrom(m => m.Street.NumberHouse))
                .ForMember(s => s.NumberEntranceOfHouse, m => m.MapFrom(m => m.Street.NumberEntranceOfHouse))
                .ForMember(s => s.NumberFlat, m => m.MapFrom(m => m.Street.NumberFlat));
        }
    }
}
