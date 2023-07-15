using APi_Ambulance.Domain.DTO.DtoCallDepartrure;
using APi_Ambulance.Domain.Entity;
using APi_Ambulance.Persistens.Repository.Interfaces.GenericRepository;
using API_Ambulance.Application.GenericInterfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;


namespace API_Ambulance.Application.Implementation
{
    public class BizServicesDepart : IBizServices<CreateAmbulanceDepartureDto>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<AmbulanceDeparture> _repository;
        public BizServicesDepart(IMapper mapper, IRepository<AmbulanceDeparture> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public async Task InsertCommand(int id, CreateAmbulanceDepartureDto entity)
        {
            if(id == 0 && entity == null)
            {
                throw new ArgumentNullException("id", nameof(entity));
            }
            var map = _mapper.Map<AmbulanceDeparture>(entity);
            await _repository.InsertCommandId(id, map);
        }
    }
}
