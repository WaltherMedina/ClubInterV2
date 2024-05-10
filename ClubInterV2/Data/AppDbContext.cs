using ClubInterV2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClubInterV2.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Usuario> TUsuario { get; set; }
        public DbSet<UsuarioLog> TUsuarioLog { get; set; }
        public DbSet<Rol> TRol { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapeo de nombres de tablas a clases de modelo
            modelBuilder.Entity<Usuario>().ToTable("TUsuario");
            modelBuilder.Entity<Rol>().ToTable("TRol");

            // configurar las relaciones entre las entidades (tablas) si es necesario
            modelBuilder.Entity<Usuario>()
            .HasOne(u => u.Rol)
            .WithMany() // Si hay una relación uno a muchos desde Rol a Usuario, utiliza WithMany(u => u.Usuarios)
            .HasForeignKey(u => u.RoleId)
            .IsRequired();

            /*modelBuilder.Entity<UsuarioLog>()
            .HasOne(u => u.RoleId)
            .WithOne(r => r.UserId)
            .HasForeignKey<Rol>(r => r.UserId);*/
        }
    }
}
