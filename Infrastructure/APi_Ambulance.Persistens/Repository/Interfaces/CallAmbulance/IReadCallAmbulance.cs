using APi_Ambulance.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APi_Ambulance.Persistens.Repository.Interfaces.CallAmbulance
{
    public interface IReadCallAmbulance
    {
        Task<CallingAmbulance> ReadCommand(int id);
    }
}
