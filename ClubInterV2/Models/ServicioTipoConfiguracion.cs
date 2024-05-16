using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubInterV2.Models
{
    public class ServicioTipoConfiguracion : IEntityTypeConfiguration<ServicioTipo>
    {
        public void Configure(EntityTypeBuilder<ServicioTipo> builder)
        {
            builder.ToTable("TServicioTipo");
            builder.HasKey(st => st.ServicioTipoId);

            builder.HasMany(st => st.Servicios)
                .WithOne(s => s.ServiTipo)
                .HasForeignKey(s => s.ServicioTipoId);
        }
    }
}
