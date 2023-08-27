using APi_Ambulance.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using APi_Ambulance.Persistens.CodeEfCore;
using APi_Ambulance.Persistens.Repository.Interfaces.Patient;
using StatusGeneric;
using APi_Ambulance.Domain.DTO.DToPatient;
using APi_Ambulance.Domain.DTO.DTOPatient;

namespace APi_Ambulance.Persistens.Repository.Implementations
{
    public class EmplementationRepositoryPatient : IRepositoryPatient<Patient>
    {
        private readonly EfCoreDbContext _context;
        public EmplementationRepositoryPatient(EfCoreDbContext context)
        {
            _context = context;
        }

        public async Task AddNewCommandAsync(Patient create)
        {
            if(create==null)
            {
                throw new ArgumentNullException(nameof(create));
            }
            _context.Entry(create).State = EntityState.Added;
            await _context.SaveChangesAsync();
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

        public async Task<IStatusGeneric> UpdateCommandAsync(Patient update)
        {
            var status = new StatusGenericHandler();
            if(update == null)
            {
                status.AddError("параметр метода  имеет значение null", nameof(update));
            }
            if (status.IsValid)
            _context.Entry(update!).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return status;
        }
        public async Task<ActionSearchPatientDto> GetSearchPatient(PatientFilter filter)
        {
            if(filter.Search == null)
            {
                await _context.Patients.ToListAsync();
            }
            var search = _context.Patients.AsNoTracking()
                .Where(x => x.Name.Contains(filter.Search) || x.Family_Name.Contains(filter.Search))
                .Include(l => l.Locality)
                .Include(s => s.Street)
                .ToList();

            var countPatient = search.Count();

            return new ActionSearchPatientDto()
            {
                Count = countPatient,
                PatientReads = search
            };
            
        }
    }
}
