using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubInterV2.Models
{
    public class PersonaConfiguracion : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("TPersona");
            builder.HasKey(p => p.PersonaId);

            builder.HasMany(p => p.ComprobantesDeuda)
                .WithOne(cdd => cdd.Perso)
                .HasForeignKey(cdd => cdd.PersonaId);
        }
    }
}
