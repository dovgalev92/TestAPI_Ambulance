using APi_Ambulance.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace APi_Ambulance.Persistens.ConfigurationEntity
{
    public class DepartureConfig : IEntityTypeConfiguration<AmbulanceDeparture>
    {
        public void Configure(EntityTypeBuilder<AmbulanceDeparture> entity)
        {
            entity.HasKey(pk => pk.AmbulanceDepartureId);
            entity
                .HasOne(p => p.Patient)
                .WithMany(a => a.AmbulanceDepartures)
                .HasForeignKey(fk => fk.PatientId)
                .IsRequired();
            entity.Property(d => d.DateDepart).HasColumnType("date");
        }
    }
}
