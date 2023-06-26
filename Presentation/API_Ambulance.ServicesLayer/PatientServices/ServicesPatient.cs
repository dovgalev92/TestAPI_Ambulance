using APi_Ambulance.Domain.DTO.DTOPatient;
using APi_Ambulance.Domain.Entity;
using APi_Ambulance.Persistens.CodeEfCore;
using API_Ambulance.ServicesLayer.BizRunnerDb;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Ambulance.ServicesLayer.PatientServices
{
    public class ServicesPatient
    {
        private readonly RunnerWriteDb<Patient, PatientWriteDto> _runner;
        public IImmutableList<ValidationResult> Errors => _runner.Errors;

        public ServicesPatient(EfCoreDbContext _context)
        {
            _runner = new RunnerWriteDb<Patient, PatientWriteDto>(
                new )
        }
    }
}
