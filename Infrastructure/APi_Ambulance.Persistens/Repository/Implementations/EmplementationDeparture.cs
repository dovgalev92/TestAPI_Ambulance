using APi_Ambulance.Domain.Entity;
using APi_Ambulance.Persistens.CodeEfCore;
using APi_Ambulance.Persistens.Repository.Interfaces.Repo;
using Microsoft.EntityFrameworkCore;


namespace APi_Ambulance.Persistens.Repository.Implementations
{
    public class EmplementationDeparture : IRepository<AmbulanceDeparture>
    {
        private readonly EfCoreDbContext _context;
        public EmplementationDeparture(EfCoreDbContext context)
        {
            _context = context;
        }
        public async Task InsertCommandId(int id, AmbulanceDeparture insert)
        {
            if(id == 0 && insert == null)
            {
                throw new ArgumentNullException("id",nameof(insert));
            }
            insert.Calling = await _context.CallingAmbulances.Where(c => c.CallingAmbulanceId == id).SingleOrDefaultAsync();
            insert.Patient = await _context.Patients.Where(p => p.PatientId == id).SingleOrDefaultAsync();

            await _context.AddAsync(insert);
            await _context.SaveChangesAsync();
        }
    }
}
