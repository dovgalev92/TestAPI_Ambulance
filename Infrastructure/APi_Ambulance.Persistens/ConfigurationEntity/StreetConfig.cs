using APi_Ambulance.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APi_Ambulance.Persistens.ConfigurationEntity
{
    public class StreetConfig : IEntityTypeConfiguration<Street>
    {
        public void Configure(EntityTypeBuilder<Street> builder) 
        {
            builder.HasKey(pk => pk.StreetId);
            builder
                .HasOne(l => l.Locality)
                .WithMany(s => s.Streets)
                .HasForeignKey(fk => fk.LocalityId)
                .IsRequired();
            builder
                .HasMany(p => p.Patients)
                .WithOne(s => s.Street);      
        }
    }
}
