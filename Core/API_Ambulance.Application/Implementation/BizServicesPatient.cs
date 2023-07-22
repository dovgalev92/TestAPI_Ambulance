
using APi_Ambulance.Domain.DTO.DToPatient;
using APi_Ambulance.Domain.DTO.DTOPatient;
using APi_Ambulance.Domain.Entity;
using APi_Ambulance.Persistens.Repository.Interfaces.Patient;
using API_Ambulance.Application.GenericInterfaces;
using AutoMapper;
using StatusGeneric;
using System.Diagnostics.CodeAnalysis;

namespace API_Ambulance.Application.Implementation
{
    public class BizServicesPatient : IBizServicesPatient<PatientWriteDto,PatientReadIdDto, PatientUpdateDto, PatientReadDto>
    {
        private readonly IRepositoryPatient<Patient> _repository;
        private IMapper _mapper;

        public BizServicesPatient(IRepositoryPatient<Patient> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task AddCommandServices(PatientWriteDto create)
        {
            var map = create!=null? _mapper.Map<Patient>(create) : throw new ArgumentNullException(nameof(create));
            await _repository.AddNewCommandAsync(map);
        }
        public async Task<IEnumerable<PatientReadDto>> GetAllCommandServices()
        {
            var allPatient = await _repository.GetAllCommandAsync();
            return _mapper.Map<IEnumerable<PatientReadDto>>(allPatient);
        }

        public async Task<PatientReadIdDto> GetCommandIdServices(int id)
        {
            var readMapPatientId = await _repository.GetCommandIdAsync(id);
            
            return _mapper.Map<PatientReadIdDto>(readMapPatientId);
        }

        public async Task UpdateCommandServices(int id, PatientUpdateDto update)
        {
            var patientId = await _repository.GetCommandIdAsync(id);
            var map = _mapper.Map(update, patientId);
            await _repository.UpdateCommandAsync(map);
        }

    }
}
