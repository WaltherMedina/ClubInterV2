using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubInterV2.Models
{
    public class CajaConciliacionDetalleConfiguracion : IEntityTypeConfiguration<CajaConciliacionDetalle>
    {
        public void Configure(EntityTypeBuilder<CajaConciliacionDetalle> builder)
        {
            builder.ToTable("TCajaConciliacionDetalle");
            builder.HasKey(ccd => ccd.CConciDetalleId);
        }
    }
}
