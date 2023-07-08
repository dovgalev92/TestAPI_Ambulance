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
            builder.Property(d => d.BirthYear)
                .HasColumnType("date");
            builder
                .HasOne(s => s.Street)
                .WithMany(p => p.Patients)
                .HasForeignKey(p => p.StreetId);
            builder
                .HasOne(l => l.Locality)
                .WithMany(p => p.Patients)
                .HasForeignKey(fk => fk.LocalityId);
            builder
                .HasMany(c => c.CallingAmbulances)
                .WithOne(p => p.Patient)
                .HasForeignKey(fk => fk.PatientId)
                .IsRequired();
                
        }
    }
}
