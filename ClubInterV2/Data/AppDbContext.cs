using ClubInterV2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace ClubInterV2.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> TUsuario { get; set; }
        public DbSet<UsuarioLog> TUsuarioLog { get; set; }
        public DbSet<Rol> TRol { get; set; }
        public DbSet<Persona> TPersona { get; set; }
        public DbSet<Servicio> TServicio { get; set; }
        public DbSet<ServicioTipo> TServicioTipo { get; set; }
        public DbSet<ComprobanteDeuda> TComprobanteDeuda { get; set; }
        public DbSet<ComprobanteDetalle> TComprobantePagoDetalle { get; set; }
        public DbSet<ComprobanteCabecera> TComprobantePagoCabecera { get; set; }
        public DbSet<Pago> TPago { get; set; }
        public DbSet<TipoMoneda> TSUNATTipoMoneda { get; set; }
        public DbSet<TipoAfectacion> TSUNATTipoAfectacion { get; set; }
        public DbSet<UnidadMedida> TSUNATUnidadMedida { get; set; }
        

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UsuarioConfiguracion());
            modelBuilder.ApplyConfiguration(new UsuarioLogConfiguracion());
            modelBuilder.ApplyConfiguration(new RolConfiguracion());
            modelBuilder.ApplyConfiguration(new PersonaConfiguracion());
            modelBuilder.ApplyConfiguration(new ServicioConfiguracion());
            modelBuilder.ApplyConfiguration(new ServicioTipoConfiguracion());
            modelBuilder.ApplyConfiguration(new ComprobanteDeudaConfiguracion());
            modelBuilder.ApplyConfiguration(new ComprobanteDetalleConfiguracion());
            modelBuilder.ApplyConfiguration(new ComprobanteCabeceraConfiguracion());
            modelBuilder.ApplyConfiguration(new PagoConfiguracion());
            modelBuilder.ApplyConfiguration(new TipoMonedaConfiguracion());
            modelBuilder.ApplyConfiguration(new TipoAfectacionConfiguracion());
            modelBuilder.ApplyConfiguration(new UnidadMedidaConfiguracion());

        }
    }
}
