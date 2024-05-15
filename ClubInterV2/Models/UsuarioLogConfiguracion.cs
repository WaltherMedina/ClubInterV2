using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubInterV2.Models
{
    public class UsuarioLogConfiguracion : IEntityTypeConfiguration<UsuarioLog>
    {
        public void Configure(EntityTypeBuilder<UsuarioLog> builder)
        {
            builder.ToTable("TUsuarioLog");
            builder.HasKey(ul => ul.LogUId);
        }
    }
}
