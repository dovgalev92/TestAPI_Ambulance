using APi_Ambulance.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using APi_Ambulance.Persistens.CodeEfCore;
using APi_Ambulance.Persistens.Repository.Interfaces.Patient;
using StatusGeneric;

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
            return  await Task.Run(() => _context.Patients!
                .Include(l => l.Locality)
                .Include(s => s.Street)
                .AsNoTracking()
                .ToListAsync());
        }

        public async Task<Patient> GetCommandIdAsync(int id)
        {
            if(id == 0)
            {
                throw new ArgumentNullException(nameof(id));
            }
            return await Task.Run(()=> _context.Patients!
            .Where(p => p.PatientId == id)
            .AsNoTracking()
            .SingleOrDefaultAsync());
        }

        public  IStatusGeneric UpdateCommand(Patient update)
        {
            var status = new StatusGenericHandler();
            if(update == null)
            {
                status.AddError("параметр метода UpdateCommand имеет значение null", nameof(update));
            }
            if(!status.IsValid)
            return status;

            _context.Entry(update).State = EntityState.Modified;
            _context.SaveChanges();
            return status;
        }
    }
}
