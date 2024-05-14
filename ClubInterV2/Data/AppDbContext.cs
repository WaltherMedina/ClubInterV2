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
            modelBuilder.Entity<UsuarioLog>().ToTable("TUsuarioLog");
            modelBuilder.Entity<Pago>().ToTable("TPago");
            modelBuilder.Entity<ComprobanteDeuda>().ToTable("TComprobanteDeuda");
            modelBuilder.Entity<ComprobanteDetalle>().ToTable("TComprobantePagoDetalle");
            modelBuilder.Entity<ComprobanteCabecera>().ToTable("TComprobantePagoCabecera");

            // configurar las relaciones entre las entidades (tablas) si es necesario
            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Rol)
                .WithMany() // Si hay una relación uno a muchos desde Rol a Usuario, utiliza WithMany(u => u.Usuarios)
                .HasForeignKey(u => u.RoleId)
                .IsRequired();

            modelBuilder.Entity<UsuarioLog>()
                .HasOne(ul => ul.User)
                .WithMany()
                .HasForeignKey(ul => ul.UserId)
                .IsRequired();



            /*modelBuilder.Entity<UsuarioLog>()
            .HasOne(u => u.RoleId)
            .WithOne(r => r.UserId)
            .HasForeignKey<Rol>(r => r.UserId);*/
        }
    }
}
