using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubInterV2.Models
{
    public class ComprobanteDetalleConfiguracion : IEntityTypeConfiguration<ComprobanteDetalle>
    {
        public void Configure(EntityTypeBuilder<ComprobanteDetalle> builder)
        {
            builder.ToTable("TComprobantePagoDetalle");
            builder.HasKey(cdt => cdt.ComprobanteDetalleId);
        }
    }
}
