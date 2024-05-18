using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubInterV2.Models
{
    public class CajaConfiguracion : IEntityTypeConfiguration<Caja>
    {
        public void Configure(EntityTypeBuilder<Caja> builder)
        {
            builder.ToTable("TCaja");
            builder.HasKey(c => c.CajaId);

            builder.HasMany(c => c.CTrunoConcis)
                .WithOne(ctc => ctc.CajaEnlace)
                .HasForeignKey(ctc => ctc.CajaId);

            builder.HasMany(c => c.CSeries)
                .WithOne(cs => cs.CajaEnlace)
                .HasForeignKey(cs => cs.CajaId);
        }
    }
}
