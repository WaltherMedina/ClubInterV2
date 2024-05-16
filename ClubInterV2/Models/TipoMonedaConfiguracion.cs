using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubInterV2.Models
{
    public class TipoMonedaConfiguracion : IEntityTypeConfiguration<TipoMoneda>
    {
        public void Configure(EntityTypeBuilder<TipoMoneda> builder)
        {
            builder.ToTable("TSUNATTipoMoneda");
            builder.HasKey(tm => tm.TipoMonedaId);

            builder.HasMany(tm => tm.Pagos)
                .WithOne(p => p.TMoneda)
                .HasForeignKey(p => p.TipoMonedaId);

            builder.HasMany(tm => tm.ComprobantesDetalle)
                .WithOne(cdt => cdt.TMoneda)
                .HasForeignKey(cdt => cdt.TipoMonedaId);

            builder.HasMany(tm => tm.ComprobantesCabecera)
                .WithOne(cca => cca.TMoneda)
                .HasForeignKey(cca => cca.TipoMonedaId);
        }
    }
}
