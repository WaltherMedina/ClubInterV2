using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubInterV2.Models
{
    public class MetodoPagoConfiguracion : IEntityTypeConfiguration<MetodoPago>
    {
        public void Configure(EntityTypeBuilder<MetodoPago> builder)
        {
            builder.ToTable("TMetodoPago");
            builder.HasKey(mtp => mtp.MetodoPagoId);
        }
    }
}
