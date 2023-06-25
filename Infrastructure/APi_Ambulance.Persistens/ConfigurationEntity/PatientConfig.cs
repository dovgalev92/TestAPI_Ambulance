using APi_Ambulance.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APi_Ambulance.Persistens.ConfigurationEntity
{
    public class PatientConfig : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(pk => pk.PatientId);
            builder
                .HasMany(c => c.CallingAmbulances)
                .WithOne(c => c.Patient)
                .HasForeignKey(fk => fk.PatientId)
                .IsRequired();
        }
    }
}
