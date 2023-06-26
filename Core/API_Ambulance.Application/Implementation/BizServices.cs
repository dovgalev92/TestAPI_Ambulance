using APi_Ambulance.Domain.DTO.DToCallAmbul;
using API_Ambulance.Application.GenericInterfaces;
using APi_Ambulance.Persistens.Repository.Interfaces.Repo;
using AutoMapper;
using APi_Ambulance.Domain.Entity;

namespace API_Ambulance.Application.Implementation
{
    public class BizServices : IBizServices<CreateCallAmbulDto>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<CallingAmbulance> _repository;
        public BizServices(IMapper mapper, IRepository<CallingAmbulance> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task InsertCommand(int id, CreateCallAmbulDto entity)
        {
            var map = _mapper.Map<CallingAmbulance>(entity);
            await _repository.InsertCommandId(id, map);
        }
    }
}
