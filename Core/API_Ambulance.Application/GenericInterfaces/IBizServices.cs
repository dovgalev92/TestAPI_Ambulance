using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Ambulance.Application.GenericInterfaces
{
    public interface IBizServices<in TIn, TOut>
    {
        void AddCommandServices(TIn create);
        Task<IEnumerable<TOut>> GetAllCommandServices();
        Task<TOut> GetCommandIdServices(int id);
        Task UpdateCommandServices(TIn update);
    }
}
