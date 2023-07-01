using APi_Ambulance.Domain.Entity;
using APi_Ambulance.Persistens.CodeEfCore;
using APi_Ambulance.Persistens.Repository.Interfaces.Repo;
using Microsoft.EntityFrameworkCore;


namespace APi_Ambulance.Persistens.Repository.Implementations
{
    public class EmplementationDepart : IRepository<AmbulanceDeparture>
    {
        private readonly EfCoreDbContext _context;
        public EmplementationDepart(EfCoreDbContext context)
        {
            _context = context;
        }
        public async Task InsertCommandId(int id, AmbulanceDeparture insert)
        {
            if(id == 0 && insert == null)
            {
                throw new ArgumentNullException("id", nameof(insert));
            }
            insert.Patient = await _context.Patients!.Where(i => i.PatientId == id).SingleOrDefaultAsync();
            await _context.AddAsync(insert);
            await _context.SaveChangesAsync();
        }
    }
}
