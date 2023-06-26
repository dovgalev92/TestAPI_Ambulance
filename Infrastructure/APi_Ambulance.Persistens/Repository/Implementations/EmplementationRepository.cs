using APi_Ambulance.Persistens.Repository.Interfaces;
using APi_Ambulance.Domain.Entity;
using APi_Ambulance.Domain.DTO.DTOPatient;
using Microsoft.EntityFrameworkCore;
using APi_Ambulance.Persistens.CodeEfCore;

namespace APi_Ambulance.Persistens.Repository.Implementations
{
    public class EmplementationRepository : IRepository<Patient, PatientWriteDto>
    {
        private readonly EfCoreDbContext _context;
        public EmplementationRepository(EfCoreDbContext context)
        {
            _context = context;
        }
        public void AddNewCommandAsync(Patient create)
        {
            _context.Entry(create).State = EntityState.Added;
            _context.SaveChanges();
        }

        public Task<IEnumerable<PatientWriteDto>> GetAllCommandAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PatientWriteDto> GetCommandIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCommandAsync(Patient update)
        {
            throw new NotImplementedException();
        }
      

    }
}
