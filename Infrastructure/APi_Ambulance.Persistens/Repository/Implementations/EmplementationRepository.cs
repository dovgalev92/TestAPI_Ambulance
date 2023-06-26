using APi_Ambulance.Persistens.Repository.Interfaces;
using APi_Ambulance.Domain.Entity;
using APi_Ambulance.Domain.DTO.DTOPatient;
using Microsoft.EntityFrameworkCore;
using APi_Ambulance.Persistens.CodeEfCore;
using APi_Ambulance.Domain.DTO.DToPatient;

namespace APi_Ambulance.Persistens.Repository.Implementations
{
    public class EmplementationRepository : IRepository<Patient>
    {
        private readonly EfCoreDbContext _context;
        public EmplementationRepository(EfCoreDbContext context)
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
            return  await _context.Patients!.Include(c => c.CallingAmbulances)
                .Include(a => a.AmbulanceDepartures)
                .Include(l => l.Locality)
                .ThenInclude(s => s.Streets)
                .AsNoTracking()
                .ToListAsync();
        }

        public Task<Patient> GetCommandIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCommandAsync(Patient update)
        {
            throw new NotImplementedException();
        }
    }
}
