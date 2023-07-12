using APi_Ambulance.Domain.Entity;
using APi_Ambulance.Persistens.CodeEfCore;
using APi_Ambulance.Persistens.Repository.Interfaces.Repo;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

namespace APi_Ambulance.Persistens.Repository.Implementations
{
    public class EmplementationDeparture : IRepository<AmbulanceDeparture>
    {
        private readonly EfCoreDbContext _context;
        public EmplementationDeparture(EfCoreDbContext context)
        {
            _context = context;
        }
       // метод под замену!!!
        public async Task InsertCommandId(int id, AmbulanceDeparture insert)
        {
            if (id == 0 && insert == null)
            {
                throw new ArgumentNullException("id", nameof(insert));
            }
            insert.Calling = await Task.Run(() => _context.CallingAmbulances.Where(c => c.CallingAmbulanceId == id).SingleOrDefaultAsync());
            insert.Patient = await _context.Patients.Where(i => i.PatientId == id).FirstOrDefaultAsync();

            await _context.AddAsync(insert);
            await _context.SaveChangesAsync();
        }
        
    }
}
