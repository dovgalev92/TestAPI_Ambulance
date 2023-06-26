using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Ambulance.Application.GenericInterfaces
{
    public interface IBizServices<in TIn, TOut>
    {
        void WriteNewCommand(TIn write);
        Task<TOut> ReadCommandId(int id);
        Task UpdateCommand(TIn update);
        Task<IEnumerable<TOut>> ReadAllCommand();

    }
}
