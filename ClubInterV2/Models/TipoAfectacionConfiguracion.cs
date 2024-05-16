using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubInterV2.Models
{
    public class TipoAfectacionConfiguracion : IEntityTypeConfiguration<TipoAfectacion>
    {
        public void Configure(EntityTypeBuilder<TipoAfectacion> builder)
        {
            builder.ToTable("TSUNATTipoAfectacion");
            builder.HasKey(ta => ta.TipoAfectacionId);

            builder.HasMany(ta => ta.Servi)
                .WithOne(s => s.TipoAfectIGV)
                .HasForeignKey(s => s.TipoAfectacionId);
        }
    }
}
