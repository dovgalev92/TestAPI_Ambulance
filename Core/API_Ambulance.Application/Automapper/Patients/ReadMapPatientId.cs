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
    public class ReadMapPatientId : Profile
    {
        public ReadMapPatientId() 
        {
            CreateMap<Patient, PatientReadDto>();
        }
    }
}
