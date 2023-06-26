
using APi_Ambulance.Domain.DTO.DTOPatient;
using APi_Ambulance.Domain.Entity;
using APi_Ambulance.Persistens.Repository.Interfaces;
using API_Ambulance.Application.GenericInterfaces;
using AutoMapper;

namespace API_Ambulance.Application.Implementation
{
    public class BizServices : IBizServices<PatientWriteDto, Patient>
    {
        private readonly IRepository<Patient> _repository;
        private IMapper _mapper;

        public BizServices(IRepository<Patient> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void AddCommandServices(PatientWriteDto create)
        {
            var map = create!=null? _mapper.Map<Patient>(create) : throw new ArgumentNullException(nameof(create));
            _repository.AddNewCommandAsync(map);
        }

        public Task<IEnumerable<Patient>> GetAllCommandServices()
        {
            throw new NotImplementedException();
        }

        public Task<Patient> GetCommandIdServices(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCommandServices(PatientWriteDto update)
        {
            throw new NotImplementedException();
        }
    }
}
