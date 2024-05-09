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
            // configurar las relaciones entre las entidades (tablas) si es necesario
        }
    }
}
