using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubInterV2.Models
{
    public class ComprobanteDeudaConfiguracion : IEntityTypeConfiguration<ComprobanteDeuda>
    {
        public void Configure(EntityTypeBuilder<ComprobanteDeuda> builder)
        {
            builder.ToTable("TComprobanteDeuda");
            builder.HasKey(cdd => cdd.ComprobanteDeudaId);

        }
    }
}
