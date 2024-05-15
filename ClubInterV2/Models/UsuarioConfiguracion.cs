using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClubInterV2.Models
{
    public class UsuarioConfiguracion : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("TUsuario");
            builder.HasKey(u => u.UserId);
            builder.HasOne(u => u.Rol)
                .WithOne()
                .HasForeignKey<Rol>(r => r.RoleId);

            builder.HasOne(u => u.Perso)
                .WithOne()
                .HasForeignKey<Usuario>(u => u.PersId);

            builder.HasMany(u => u.UserLogs)
                .WithOne(ul => ul.User)
                .HasForeignKey(ul => ul.UserId);
        }
    }
}
