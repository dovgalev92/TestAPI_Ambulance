using APi_Ambulance.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Threading.Tasks;

namespace APi_Ambulance.Persistens.ConfigurationEntity
{
    public class CallAmbulConfig : IEntityTypeConfiguration<CallingAmbulance>
    {
        public void Configure(EntityTypeBuilder<CallingAmbulance> entity)
        {
            entity.HasKey(pk => pk.CallingAmbulanceId);
            entity.
                HasOne(p => p.Patient)
                .WithMany(c => c.CallingAmbulances)
                .HasForeignKey(fk => fk.PatientId)
                .IsRequired();
            entity.Property(d => d.DateCall)
                .HasColumnType("date");
        }
    }
}
