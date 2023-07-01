using APi_Ambulance.Domain.DTO.DtoCallDepartrure;
using APi_Ambulance.Domain.Entity;
using APi_Ambulance.Persistens.Repository.Interfaces.Repo;
using API_Ambulance.Application.GenericInterfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Ambulance.Application.Implementation
{
    public class BizServiceDepart : IBizServices<AmbulanceDepartureDto>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<AmbulanceDeparture> _repository;

        public BizServiceDepart(IMapper mapper, IRepository<AmbulanceDeparture> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task InsertCommand(int id, AmbulanceDepartureDto entity)
        {
            var map = _mapper.Map<AmbulanceDeparture>(entity);
            await _repository.InsertCommandId(id, map);
        }
    }
}
