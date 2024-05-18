using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubInterV2.Models
{
    public class MedioPagoConfiguracion : IEntityTypeConfiguration<MedioPago>
    {
        public void Configure(EntityTypeBuilder<MedioPago> builder)
        {
            builder.ToTable("TSUNATMedioPago");
            builder.HasKey(mp => mp.MedioPagoId);

            builder.HasMany(mp => mp.MetodosPago)
                .WithOne(mtp => mtp.MPago)
                .HasForeignKey(mtp => mtp.MedioPagoId);
        }
    }
}
