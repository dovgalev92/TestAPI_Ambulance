
using APi_Ambulance.Domain.DTO.DToPatient;
using APi_Ambulance.Domain.Entity;
using APi_Ambulance.Persistens.Repository.Interfaces.Patient;
using API_Ambulance.Application.GenericInterfaces;
using AutoMapper;

namespace API_Ambulance.Application.Implementation
{
    public class BizServicesPatient : IBizServicesPatient<PatientWriteDto, PatientReadDto>
    {
        private readonly IRepositoryPatient<Patient> _repository;
        private IMapper _mapper;

        public BizServicesPatient(IRepositoryPatient<Patient> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void AddCommandServices(PatientWriteDto create)
        {
            var map = create!=null? _mapper.Map<Patient>(create) : throw new ArgumentNullException(nameof(create));
            _repository.AddNewCommandAsync(map);
        }

        public async Task<PatientReadDto> GetCommandIdServices(int id)
        {
            var readMapPatientId = await _repository.GetCommandIdAsync(id);
            return _mapper.Map<PatientReadDto>(readMapPatientId);
        }

        public Task UpdateCommandServices(PatientWriteDto update)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<PatientReadDto>> IBizServicesPatient<PatientWriteDto, PatientReadDto>.GetAllCommandServices()
        {
            throw new NotImplementedException();
        }
    }
}
