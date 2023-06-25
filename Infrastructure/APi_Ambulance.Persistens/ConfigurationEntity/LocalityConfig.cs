using APi_Ambulance.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APi_Ambulance.Persistens.ConfigurationEntity
{
    public class LocalityConfig : IEntityTypeConfiguration<Locality>
    {
        public void Configure(EntityTypeBuilder<Locality> entity)
        {
            entity.HasKey(pk => pk.LocalityId);
            entity
                .HasMany(s => s.Streets)
                .WithOne(l => l.Locality);
            entity
                .HasMany(p => p.Patients)
                .WithOne(l => l.Locality);
        }
    }
}
