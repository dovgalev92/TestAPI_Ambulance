using APi_Ambulance.Domain.DTO.DToCallAmbul;
using APi_Ambulance.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Ambulance.Application.GenericInterfaces
{
    public interface IBizServiceReadCallAmbulance
    {
        Task<ReadCallAmbualnceDto> ReadCommandAsync(int id);
    }
}
