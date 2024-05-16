using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubInterV2.Models
{
    public class ServicioConfiguracion : IEntityTypeConfiguration<Servicio>
    {
        public void Configure(EntityTypeBuilder<Servicio> builder)
        {
            builder.ToTable("TServicio");
            builder.HasKey(s => s.ServicioId);

            builder.HasMany(s => s.ComprobantesDeuda)
                .WithOne(cdd => cdd.Servi)
                .HasForeignKey(cdd => cdd.ServicioId);

        }
    }
}
