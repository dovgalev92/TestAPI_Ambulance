using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APi_Ambulance.Persistens.Repository.Interfaces.GenericRepository
{
    public interface IRepository<T>
    {
        Task InsertCommandId(int id, T entity);
    }
}
