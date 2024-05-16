using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubInterV2.Models
{
    public class UnidadMedidaConfiguracion : IEntityTypeConfiguration<UnidadMedida>
    {
        public void Configure(EntityTypeBuilder<UnidadMedida> builder)
        {
            builder.ToTable("TSUNATUnidadMedida");
            builder.HasKey(um => um.UnidadMedidaId);

            builder.HasMany(um => um.Servicios)
                .WithOne(s => s.UniMedida)
                .HasForeignKey(s => s.UnidadMedidaId);
        }
    }
}
