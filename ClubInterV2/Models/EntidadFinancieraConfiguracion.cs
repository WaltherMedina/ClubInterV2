using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubInterV2.Models
{
    public class EntidadFinancieraConfiguracion : IEntityTypeConfiguration<EntidadFinanciera>
    {
        public void Configure(EntityTypeBuilder<EntidadFinanciera> builder)
        {
            builder.ToTable("TSUNATEntidadFinanciera");
            builder.HasKey(ef => ef.EntidadFinancieraId);

            builder.HasMany(ef => ef.MetodosPago)
                .WithOne(mp => mp.EFinanciera)
                .HasForeignKey(mp => mp.EntidadFinancieraId);
        }
    }
}
