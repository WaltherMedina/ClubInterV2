using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubInterV2.Models
{
    public class ComprobanteCabeceraConfiguracion : IEntityTypeConfiguration<ComprobanteCabecera>
    {
        public void Configure(EntityTypeBuilder<ComprobanteCabecera> builder)
        {
            builder.ToTable("TComprobantePagoCabecera");
            builder.HasKey(cca => cca.ComprobanteCabeceraId);

            builder.HasMany(cca => cca.ComprobantesDetalle)
                .WithOne(cdt => cdt.ComprCabecera)
                .HasForeignKey(cdt => cdt.ComprobanteCabeceraId);
        }
    }
}
