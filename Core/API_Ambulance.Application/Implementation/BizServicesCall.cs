using APi_Ambulance.Domain.DTO.DToCallAmbul;
using API_Ambulance.Application.GenericInterfaces;
using APi_Ambulance.Persistens.Repository.Interfaces.GenericRepository;
using AutoMapper;
using APi_Ambulance.Domain.Entity;
using APi_Ambulance.Persistens.Repository.Interfaces.CallAmbulance;

namespace API_Ambulance.Application.Implementation
{
    public class BizServicesCall : IBizServices<CreateCallAmbulDto>, IBizServiceReadCallAmbulance
    {
        private readonly IMapper _mapper;
        private readonly IRepository<CallingAmbulance> _repository;
        private readonly IReadCallAmbulance _readCallAmbulance;
        public BizServicesCall(IMapper mapper, IRepository<CallingAmbulance> repository, IReadCallAmbulance readCallAmbulance)
        {
            _mapper = mapper;
            _repository = repository;
            _readCallAmbulance = readCallAmbulance;
        }
        public async Task InsertCommand(int id, CreateCallAmbulDto entity)
        {
            var map = _mapper.Map<CallingAmbulance>(entity);
            await _repository.InsertCommandId(id, map);
        }

        public async Task<ReadCallAmbualnceDto> ReadCommandAsync(int id)
        {
            var callAmbul = await _readCallAmbulance.ReadCommand(id);
            return _mapper.Map<ReadCallAmbualnceDto>(callAmbul);
        }
    }
}
