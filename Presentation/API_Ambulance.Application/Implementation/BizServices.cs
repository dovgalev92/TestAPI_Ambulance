using APi_Ambulance.Domain.DTO.DTOPatient;
using APi_Ambulance.Domain.Entity;
using APi_Ambulance.Persistens.Repository.Interfaces;
using API_Ambulance.Application.GenericInterfaces;
using AutoMapper;

namespace API_Ambulance.Application.Implementation
{
    public class BizServices : IBizServices<PatientWriteDto, Patient>
    {
        private readonly IRepository<Patient, PatientWriteDto> _repository;
        private IMapper _mapper;
        public BizServices(IMapper mapper, IRepository<Patient, PatientWriteDto> repository)
        {
            _mapper = mapper;
            _repository = repository;

        }

        public Task<IEnumerable<Patient>> ReadAllCommand()
        {
            throw new NotImplementedException();
        }

        public Task<Patient> ReadCommandId(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCommand(PatientWriteDto update)
        {
            throw new NotImplementedException();
        }

        public void WriteNewCommand(PatientWriteDto write)
        {
            throw new NotImplementedException();
        }
    }
}
