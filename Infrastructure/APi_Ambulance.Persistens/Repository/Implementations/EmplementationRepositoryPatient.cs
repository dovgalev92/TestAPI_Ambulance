using APi_Ambulance.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using APi_Ambulance.Persistens.CodeEfCore;
using APi_Ambulance.Persistens.Repository.Interfaces.Patient;

namespace APi_Ambulance.Persistens.Repository.Implementations
{
    public class EmplementationRepositoryPatient : IRepositoryPatient<Patient>
    {
        private readonly EfCoreDbContext _context;
        public EmplementationRepositoryPatient(EfCoreDbContext context)
        {
            _context = context;
        }

        public void AddNewCommandAsync(Patient create)
        {
            if(create==null)
            {
                throw new ArgumentNullException(nameof(create));
            }
            _context.Entry(create).State = EntityState.Added;
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Patient>> GetAllCommandAsync()
        {
            return  await Task.Run(() => _context.Patients!.Include(c => c.CallingAmbulances)
                .Include(dep => dep.Departures)
                .Include(l => l.Locality)
                .ThenInclude(s => s!.Streets)
                .AsNoTracking()
                .ToListAsync());
        }

        public async Task<Patient> GetCommandIdAsync(int id)
        {
            if(id == 0)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return await Task.Run(() => _context.Patients!.Where(p => p.PatientId == id).SingleOrDefaultAsync());
        }

        public Task UpdateCommandAsync(Patient update)
        {
            throw new NotImplementedException();
        }
    }
}
