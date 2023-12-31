﻿using APi_Ambulance.Domain.DTO.DToPatient;
using APi_Ambulance.Domain.Entity;
using AutoMapper;

namespace API_Ambulance.Application.Automapper.Patients
{
    public class CreateMapPatient : Profile
    {
        public CreateMapPatient()
        {
            CreateMap<PatientWriteDto, Patient>();
        }
    }
}
