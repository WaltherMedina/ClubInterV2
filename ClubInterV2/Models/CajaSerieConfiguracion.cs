using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubInterV2.Models
{
    public class CajaSerieConfiguracion : IEntityTypeConfiguration<CajaSerie>
    {
        public void Configure(EntityTypeBuilder<CajaSerie> builder)
        {
            builder.ToTable("TCajaSerie");
            builder.HasKey(cs => cs.CajaSerieId);
        }
    }
}
