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
            entity.Property(d => d.DateDepart).HasColumnType("date");
            entity.HasOne(c => c.Calling)
                .WithOne(d => d.Departure)
                .HasForeignKey<AmbulanceDeparture>(fk => fk.CallingAmbulanceId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
            entity.
                HasOne(p => p.Patient)
                .WithMany(d => d.Departures)
                .HasForeignKey(fk => fk.PatientId)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
