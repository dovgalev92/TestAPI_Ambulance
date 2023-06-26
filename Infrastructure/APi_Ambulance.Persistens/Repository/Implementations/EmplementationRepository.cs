using APi_Ambulance.Domain.Entity;
using APi_Ambulance.Persistens.CodeEfCore;
using APi_Ambulance.Persistens.Repository.Interfaces.Repo;
using Microsoft.EntityFrameworkCore;

namespace APi_Ambulance.Persistens.Repository.Implementations
{
    public class EmplementationRepository : IRepository<CallingAmbulance>
    {
        private readonly EfCoreDbContext _context;
        public EmplementationRepository(EfCoreDbContext context)
        {
            _context = context;
        }
        public async Task InsertCommandId(int id, CallingAmbulance insert)
        {
            if (id == 0 && insert == null)
            {
                throw new ArgumentNullException(nameof(insert));
            }
            insert.Patient = await _context.Patients!.Where(x => x.PatientId == id).SingleOrDefaultAsync();
            await _context.AddAsync(insert);
            await _context.SaveChangesAsync();
        }
    }
}
