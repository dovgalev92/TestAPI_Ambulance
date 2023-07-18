using APi_Ambulance.Domain.Entity;
using APi_Ambulance.Persistens.CodeEfCore;
using APi_Ambulance.Persistens.Repository.Interfaces.CallAmbulance;
using APi_Ambulance.Persistens.Repository.Interfaces.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace APi_Ambulance.Persistens.Repository.Implementations
{
    public class EmplementationCallingRepository : IRepository<CallingAmbulance>, IReadCallAmbulance
    {
        private readonly EfCoreDbContext _context;
        public EmplementationCallingRepository(EfCoreDbContext context)
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
            if (insert.Patient == null)
            {
                throw new ArgumentNullException(nameof(insert.Patient));
            }
            await _context.AddAsync(insert);
            await _context.SaveChangesAsync();
        }
        public async Task<CallingAmbulance> ReadCommand(int id)
        {
            if(id == 0)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return  await Task.Run(() => _context.CallingAmbulances!
            .Where(x => x.CallingAmbulanceId == id)
                .Include(p => p.Patient)
                .Include(d => d.Departure)
                .AsNoTracking()
                .FirstOrDefaultAsync());

        }
    }
}
