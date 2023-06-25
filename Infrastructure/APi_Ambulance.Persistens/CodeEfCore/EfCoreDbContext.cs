using Microsoft.EntityFrameworkCore;
using APi_Ambulance.Domain.Entity;
using System.Reflection;
using APi_Ambulance.Persistens.ConfigurationEntity;

namespace APi_Ambulance.Persistens.CodeEfCore
{
    public class EfCoreDbContext : DbContext
    {
        public DbSet<Patient>? Patients { get; set; }
        public DbSet<CallingAmbulance>? CallingAmbulances { get; set; }
        public DbSet<AmbulanceDeparture>? AmbulanceDepartures { get; set; }
        public DbSet<Locality>? Localities { get; set; }
        public DbSet<Street> ? Streets { get; set; }
        public EfCoreDbContext(DbContextOptions<EfCoreDbContext>options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PatientConfig());
            modelBuilder.ApplyConfiguration(new CallAmbulConfig());
            modelBuilder.ApplyConfiguration(new DepartureConfig());
            modelBuilder.ApplyConfiguration(new LocalityConfig());
            modelBuilder.ApplyConfiguration(new StreetConfig());
        }
    }
}
