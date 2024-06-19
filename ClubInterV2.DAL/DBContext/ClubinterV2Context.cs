using System;
using System.Collections.Generic;
using ClubInterV2.Model;
using Microsoft.EntityFrameworkCore;

namespace ClubInterV2.DAL.DBContext;

public partial class ClubinterV2Context : DbContext
{
    public ClubinterV2Context()
    {
    }

    public ClubinterV2Context(DbContextOptions<ClubinterV2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Tcaja> Tcajas { get; set; }

    public virtual DbSet<TcajaConciliacionDetalle> TcajaConciliacionDetalles { get; set; }

    public virtual DbSet<TcajaConciliacionDetalleCuenta> TcajaConciliacionDetalleCuentas { get; set; }

    public virtual DbSet<TcajaConciliacionDetalleMetodoPago> TcajaConciliacionDetalleMetodoPagos { get; set; }

    public virtual DbSet<TcajaPermiso> TcajaPermisos { get; set; }

    public virtual DbSet<TcajaPermisoSerie> TcajaPermisoSeries { get; set; }

    public virtual DbSet<TcajaPermisoTurno> TcajaPermisoTurnos { get; set; }

    public virtual DbSet<TcajaSerie> TcajaSeries { get; set; }

    public virtual DbSet<TcajaTurnoConciliacion> TcajaTurnoConciliacions { get; set; }

    public virtual DbSet<TcarnetTipo> TcarnetTipos { get; set; }

    public virtual DbSet<TcomprobanteDeuda> TcomprobanteDeuda { get; set; }

    public virtual DbSet<TcomprobantePagoCabecera> TcomprobantePagoCabeceras { get; set; }

    public virtual DbSet<TcomprobantePagoDetalle> TcomprobantePagoDetalles { get; set; }

    public virtual DbSet<TcomprobanteSerie> TcomprobanteSeries { get; set; }

    public virtual DbSet<Tdireccion> Tdireccions { get; set; }

    public virtual DbSet<TdireccionTipo> TdireccionTipos { get; set; }

    public virtual DbSet<Tempresa> Tempresas { get; set; }

    public virtual DbSet<Tentidad> Tentidads { get; set; }

    public virtual DbSet<TentidadDireccion> TentidadDireccions { get; set; }

    public virtual DbSet<TestadoCivil> TestadoCivils { get; set; }

    public virtual DbSet<ThistoricoServicio> ThistoricoServicios { get; set; }

    public virtual DbSet<TmetodoPago> TmetodoPagos { get; set; }

    public virtual DbSet<Tocupacion> Tocupacions { get; set; }

    public virtual DbSet<Tpago> Tpagos { get; set; }

    public virtual DbSet<Tpai> Tpais { get; set; }

    public virtual DbSet<TparentescoTipo> TparentescoTipos { get; set; }

    public virtual DbSet<Tpermiso> Tpermisos { get; set; }

    public virtual DbSet<TpermisoTipo> TpermisoTipos { get; set; }

    public virtual DbSet<Tpersona> Tpersonas { get; set; }

    public virtual DbSet<TpersonaCarnet> TpersonaCarnets { get; set; }

    public virtual DbSet<TpersonaParentesco> TpersonaParentescos { get; set; }

    public virtual DbSet<TpersonaSalud> TpersonaSaluds { get; set; }

    public virtual DbSet<TpersonaTipo> TpersonaTipos { get; set; }

    public virtual DbSet<TpersonaTrabajo> TpersonaTrabajos { get; set; }

    public virtual DbSet<TplantillaDeudum> TplantillaDeuda { get; set; }

    public virtual DbSet<TplantillaTurnoCaja> TplantillaTurnoCajas { get; set; }

    public virtual DbSet<Trol> Trols { get; set; }

    public virtual DbSet<Tservicio> Tservicios { get; set; }

    public virtual DbSet<TservicioTipo> TservicioTipos { get; set; }

    public virtual DbSet<Tsocio> Tsocios { get; set; }

    public virtual DbSet<TsocioBeneficioMatrimonio> TsocioBeneficioMatrimonios { get; set; }

    public virtual DbSet<TsocioEstadoAdministrativo> TsocioEstadoAdministrativos { get; set; }

    public virtual DbSet<TsocioEstadoEstatutario> TsocioEstadoEstatutarios { get; set; }

    public virtual DbSet<TsocioGrupoFamiliar> TsocioGrupoFamiliars { get; set; }

    public virtual DbSet<TsocioMovimiento> TsocioMovimientos { get; set; }

    public virtual DbSet<TsocioMovimientoTipo> TsocioMovimientoTipos { get; set; }

    public virtual DbSet<TsocioTipo> TsocioTipos { get; set; }

    public virtual DbSet<TsocioTipoEstadoEspecial> TsocioTipoEstadoEspecials { get; set; }

    public virtual DbSet<TsunatentidadFinanciera> TsunatentidadFinancieras { get; set; }

    public virtual DbSet<TsunatmedioPago> TsunatmedioPagos { get; set; }

    public virtual DbSet<TsunattipoAfectacion> TsunattipoAfectacions { get; set; }

    public virtual DbSet<TsunattipoComprobante> TsunattipoComprobantes { get; set; }

    public virtual DbSet<TsunattipoDocumentoIdentidad> TsunattipoDocumentoIdentidads { get; set; }

    public virtual DbSet<TsunattipoMonedum> TsunattipoMoneda { get; set; }

    public virtual DbSet<TsunattipoNotaCredito> TsunattipoNotaCreditos { get; set; }

    public virtual DbSet<TsunatunidadMedidum> TsunatunidadMedida { get; set; }

    public virtual DbSet<TtablaMini> TtablaMinis { get; set; }

    public virtual DbSet<TturnoCaja> TturnoCajas { get; set; }

    public virtual DbSet<Tubigeo> Tubigeos { get; set; }

    public virtual DbSet<Tusuario> Tusuarios { get; set; }

    public virtual DbSet<TusuarioLog> TusuarioLogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tcaja>(entity =>
        {
            entity.HasKey(e => e.Cajaid);

            entity.ToTable("TCaja");

            entity.Property(e => e.Cajaid).HasColumnName("CAJAID");
            entity.Property(e => e.Cajaestado).HasColumnName("CAJAEstado");
            entity.Property(e => e.Cajahost)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("CAJAHost");
            entity.Property(e => e.Cajaip)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("CAJAIP");
            entity.Property(e => e.Cajamac)
                .HasMaxLength(17)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CAJAMAC");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TcajaConciliacionDetalle>(entity =>
        {
            entity.HasKey(e => e.Ccdeid);

            entity.ToTable("TCajaConciliacionDetalle");

            entity.Property(e => e.Ccdeid)
                .ValueGeneratedNever()
                .HasColumnName("CCDEID");
            entity.Property(e => e.CcdetotalCabecera)
                .HasColumnType("money")
                .HasColumnName("CCDETotalCabecera");
            entity.Property(e => e.CcdetotalDetalle)
                .HasColumnType("money")
                .HasColumnName("CCDETotalDetalle");
            entity.Property(e => e.CcdetotalPago)
                .HasColumnType("money")
                .HasColumnName("CCDETotalPago");
            entity.Property(e => e.CcdetotalRedondeo)
                .HasColumnType("money")
                .HasColumnName("CCDETotalRedondeo");
            entity.Property(e => e.Concid).HasColumnName("CONCID");
            entity.Property(e => e.Copaid).HasColumnName("COPAID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Moneid).HasColumnName("MONEID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Conc).WithMany(p => p.TcajaConciliacionDetalles)
                .HasForeignKey(d => d.Concid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TCajaConciliacionDetalle_TCajaTurnoConciliacion");

            entity.HasOne(d => d.Copa).WithMany(p => p.TcajaConciliacionDetalles)
                .HasForeignKey(d => d.Copaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TCajaConciliacionDetalle_TComprobantePagoCabecera");

            entity.HasOne(d => d.Mone).WithMany(p => p.TcajaConciliacionDetalles)
                .HasForeignKey(d => d.Moneid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TCajaConciliacionDetalle_TSUNATTipoMoneda");
        });

        modelBuilder.Entity<TcajaConciliacionDetalleCuenta>(entity =>
        {
            entity.HasKey(e => e.Ccdcid);

            entity.ToTable("TCajaConciliacionDetalleCuentas");

            entity.Property(e => e.Ccdcid)
                .ValueGeneratedNever()
                .HasColumnName("CCDCID");
            entity.Property(e => e.Ccdccuenta)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("CCDCCuenta");
            entity.Property(e => e.CcdcmontoTotal)
                .HasColumnType("money")
                .HasColumnName("CCDCMontoTotal");
            entity.Property(e => e.Concid).HasColumnName("CONCID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Moneid).HasColumnName("MONEID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Conc).WithMany(p => p.TcajaConciliacionDetalleCuenta)
                .HasForeignKey(d => d.Concid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TCajaConciliacionDetalleCuentas_TCajaTurnoConciliacion");
        });

        modelBuilder.Entity<TcajaConciliacionDetalleMetodoPago>(entity =>
        {
            entity.HasKey(e => e.Ccdmid);

            entity.ToTable("TCajaConciliacionDetalleMetodoPago");

            entity.Property(e => e.Ccdmid)
                .ValueGeneratedNever()
                .HasColumnName("CCDMID");
            entity.Property(e => e.Ccdmcantidad).HasColumnName("CCDMCantidad");
            entity.Property(e => e.Ccdmcuenta)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("CCDMCuenta");
            entity.Property(e => e.CcdmpagoTotal)
                .HasColumnType("money")
                .HasColumnName("CCDMPagoTotal");
            entity.Property(e => e.CcdmredondeoTotal)
                .HasColumnType("money")
                .HasColumnName("CCDMRedondeoTotal");
            entity.Property(e => e.Concid).HasColumnName("CONCID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Mepaid).HasColumnName("MEPAID");
            entity.Property(e => e.Moneid).HasColumnName("MONEID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Conc).WithMany(p => p.TcajaConciliacionDetalleMetodoPagos)
                .HasForeignKey(d => d.Concid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TCajaConciliacionDetalleMetodoPago_TCajaTurnoConciliacion");

            entity.HasOne(d => d.Mepa).WithMany(p => p.TcajaConciliacionDetalleMetodoPagos)
                .HasForeignKey(d => d.Mepaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TCajaConciliacionDetalleMetodoPago_TMetodoPago");

            entity.HasOne(d => d.Mone).WithMany(p => p.TcajaConciliacionDetalleMetodoPagos)
                .HasForeignKey(d => d.Moneid)
                .HasConstraintName("FK_TCajaConciliacionDetalleMetodoPago_TSUNATTipoMoneda");
        });

        modelBuilder.Entity<TcajaPermiso>(entity =>
        {
            entity.HasKey(e => e.Capeid);

            entity.ToTable("TCajaPermiso");

            entity.Property(e => e.Capeid)
                .ValueGeneratedNever()
                .HasColumnName("CAPEID");
            entity.Property(e => e.Cajaid).HasColumnName("CAJAID");
            entity.Property(e => e.CapefechaFin).HasColumnName("CAPEFechaFin");
            entity.Property(e => e.CapefechaInicio).HasColumnName("CAPEFechaInicio");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<TcajaPermisoSerie>(entity =>
        {
            entity.HasKey(e => e.Capsid);

            entity.ToTable("TCajaPermisoSerie");

            entity.Property(e => e.Capsid)
                .ValueGeneratedNever()
                .HasColumnName("CAPSID");
            entity.Property(e => e.Capeid).HasColumnName("CAPEID");
            entity.Property(e => e.Capsestado)
                .HasDefaultValue(true)
                .HasColumnName("CAPSEstado");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Seriid).HasColumnName("SERIID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Cape).WithMany(p => p.TcajaPermisoSeries)
                .HasForeignKey(d => d.Capeid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TCajaPermisoSerie_TCajaPermiso");

            entity.HasOne(d => d.Seri).WithMany(p => p.TcajaPermisoSeries)
                .HasForeignKey(d => d.Seriid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TCajaPermisoSerie_TComprobanteSerie");
        });

        modelBuilder.Entity<TcajaPermisoTurno>(entity =>
        {
            entity.HasKey(e => e.Captid);

            entity.ToTable("TCajaPermisoTurno");

            entity.Property(e => e.Captid)
                .ValueGeneratedNever()
                .HasColumnName("CAPTID");
            entity.Property(e => e.Capeid).HasColumnName("CAPEID");
            entity.Property(e => e.Captestado)
                .HasDefaultValue(true)
                .HasColumnName("CAPTEstado");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Ptcjid).HasColumnName("PTCJID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Cape).WithMany(p => p.TcajaPermisoTurnos)
                .HasForeignKey(d => d.Capeid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TCajaPermisoTurno_TCajaPermiso");

            entity.HasOne(d => d.Ptcj).WithMany(p => p.TcajaPermisoTurnos)
                .HasForeignKey(d => d.Ptcjid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TCajaPermisoTurno_TPlantillaTurnoCaja");
        });

        modelBuilder.Entity<TcajaSerie>(entity =>
        {
            entity.HasKey(e => e.Caseid);

            entity.ToTable("TCajaSerie");

            entity.Property(e => e.Caseid).HasColumnName("CASEID");
            entity.Property(e => e.Cajaid).HasColumnName("CAJAID");
            entity.Property(e => e.Caseestado).HasColumnName("CASEEstado");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Seriid).HasColumnName("SERIID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Caja).WithMany(p => p.TcajaSeries)
                .HasForeignKey(d => d.Cajaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TCajaSerie_TCaja");

            entity.HasOne(d => d.Seri).WithMany(p => p.TcajaSeries)
                .HasForeignKey(d => d.Seriid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TCajaSerie_TComprobanteSerie");
        });

        modelBuilder.Entity<TcajaTurnoConciliacion>(entity =>
        {
            entity.HasKey(e => e.Concid);

            entity.ToTable("TCajaTurnoConciliacion");

            entity.Property(e => e.Concid)
                .ValueGeneratedNever()
                .HasColumnName("CONCID");
            entity.Property(e => e.Cajaid).HasColumnName("CAJAID");
            entity.Property(e => e.Concapertura)
                .HasColumnType("datetime")
                .HasColumnName("CONCApertura");
            entity.Property(e => e.Conccerrado).HasColumnName("CONCCerrado");
            entity.Property(e => e.Conccierre)
                .HasColumnType("datetime")
                .HasColumnName("CONCCierre");
            entity.Property(e => e.Concdescuadre)
                .HasColumnType("money")
                .HasColumnName("CONCDescuadre");
            entity.Property(e => e.Concestado).HasColumnName("CONCEstado");
            entity.Property(e => e.ConcmontoFinal)
                .HasColumnType("money")
                .HasColumnName("CONCMontoFinal");
            entity.Property(e => e.ConcmontoInicial)
                .HasColumnType("money")
                .HasColumnName("CONCMontoInicial");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Moneid).HasColumnName("MONEID");
            entity.Property(e => e.Tucaid).HasColumnName("TUCAID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Userid).HasColumnName("USERID");

            entity.HasOne(d => d.Caja).WithMany(p => p.TcajaTurnoConciliacions)
                .HasForeignKey(d => d.Cajaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TCajaTurnoConciliacion_TCaja");

            entity.HasOne(d => d.Mone).WithMany(p => p.TcajaTurnoConciliacions)
                .HasForeignKey(d => d.Moneid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TCajaTurnoConciliacion_TSUNATTipoMoneda");

            entity.HasOne(d => d.Tuca).WithMany(p => p.TcajaTurnoConciliacions)
                .HasForeignKey(d => d.Tucaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TCajaTurnoConciliacion_TTurnoCaja");

            entity.HasOne(d => d.User).WithMany(p => p.TcajaTurnoConciliacions)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TCajaTurnoConciliacion_TUsuario");
        });

        modelBuilder.Entity<TcarnetTipo>(entity =>
        {
            entity.HasKey(e => e.Ticaid);

            entity.ToTable("TCarnetTipo");

            entity.Property(e => e.Ticaid).HasColumnName("TICAID");
            entity.Property(e => e.Ticadescripcion)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("TICADescripcion");
            entity.Property(e => e.Ticaestado)
                .HasDefaultValue(true)
                .HasColumnName("TICAEstado");
        });

        modelBuilder.Entity<TcomprobanteDeuda>(entity =>
        {
            entity.HasKey(e => e.Codeid);

            entity.ToTable("TComprobanteDeuda");

            entity.Property(e => e.Codeid)
                .ValueGeneratedNever()
                .HasColumnName("CODEID");
            entity.Property(e => e.Codeanulado).HasColumnName("CODEAnulado");
            entity.Property(e => e.Codecantidad).HasColumnName("CODECantidad");
            entity.Property(e => e.CodecentroCosto)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("CODECentroCosto");
            entity.Property(e => e.Codecuenta)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("CODECuenta");
            entity.Property(e => e.Codedebe).HasColumnName("CODEDebe");
            entity.Property(e => e.Codedescuento)
                .HasColumnType("money")
                .HasColumnName("CODEDescuento");
            entity.Property(e => e.Codeglosa)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("CODEGlosa");
            entity.Property(e => e.Codeigv)
                .HasColumnType("money")
                .HasColumnName("CODEIGV");
            entity.Property(e => e.Codenumero).HasColumnName("CODENumero");
            entity.Property(e => e.Codeperiodo).HasColumnName("CODEPeriodo");
            entity.Property(e => e.Codeprecio)
                .HasColumnType("money")
                .HasColumnName("CODEPrecio");
            entity.Property(e => e.Codeserie)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CODESerie");
            entity.Property(e => e.Codevencimiento).HasColumnName("CODEVencimiento");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Entiid).HasColumnName("ENTIID");
            entity.Property(e => e.Moneid).HasColumnName("MONEID");
            entity.Property(e => e.Servid).HasColumnName("SERVID");
            entity.Property(e => e.Ticoid).HasColumnName("TICOID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Enti).WithMany(p => p.TcomprobanteDeuda)
                .HasForeignKey(d => d.Entiid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TComprobanteDeuda_TEntidad");

            entity.HasOne(d => d.Serv).WithMany(p => p.TcomprobanteDeuda)
                .HasForeignKey(d => d.Servid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TComprobanteDeuda_TServicio");

            entity.HasOne(d => d.Tico).WithMany(p => p.TcomprobanteDeuda)
                .HasForeignKey(d => d.Ticoid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TComprobanteDeuda_TSUNATTipoComprobante");
        });

        modelBuilder.Entity<TcomprobantePagoCabecera>(entity =>
        {
            entity.HasKey(e => e.Copaid);

            entity.ToTable("TComprobantePagoCabecera");

            entity.Property(e => e.Copaid)
                .ValueGeneratedNever()
                .HasColumnName("COPAID");
            entity.Property(e => e.Copaanulado).HasColumnName("COPAAnulado");
            entity.Property(e => e.Copacuenta)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("COPACuenta");
            entity.Property(e => e.CopadescuentoGlobal)
                .HasColumnType("money")
                .HasColumnName("COPADescuentoGlobal");
            entity.Property(e => e.Copadetraccion)
                .HasColumnType("money")
                .HasColumnName("COPADetraccion");
            entity.Property(e => e.CopaformaPago)
                .HasDefaultValue((byte)1)
                .HasComment("1 contado 2 credito")
                .HasColumnName("COPAFormaPago");
            entity.Property(e => e.Copaigvtotal)
                .HasColumnType("money")
                .HasColumnName("COPAIGVTotal");
            entity.Property(e => e.CopamontoTotal)
                .HasColumnType("money")
                .HasColumnName("COPAMontoTotal");
            entity.Property(e => e.Copanumero).HasColumnName("COPANumero");
            entity.Property(e => e.CopanumeroSocio)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COPANumeroSocio");
            entity.Property(e => e.Copaserie)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("COPASerie");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Entiid).HasColumnName("ENTIID");
            entity.Property(e => e.Moneid).HasColumnName("MONEID");
            entity.Property(e => e.Ticoid).HasColumnName("TICOID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Enti).WithMany(p => p.TcomprobantePagoCabeceras)
                .HasForeignKey(d => d.Entiid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TComprobantePagoCabecera_TEntidad");

            entity.HasOne(d => d.Mone).WithMany(p => p.TcomprobantePagoCabeceras)
                .HasForeignKey(d => d.Moneid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TComprobantePagoCabecera_TSUNATTipoMoneda");

            entity.HasOne(d => d.Tico).WithMany(p => p.TcomprobantePagoCabeceras)
                .HasForeignKey(d => d.Ticoid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TComprobantePagoCabecera_TSUNATTipoComprobante");
        });

        modelBuilder.Entity<TcomprobantePagoDetalle>(entity =>
        {
            entity.HasKey(e => e.Copdid);

            entity.ToTable("TComprobantePagoDetalle");

            entity.Property(e => e.Copdid)
                .ValueGeneratedNever()
                .HasColumnName("COPDID");
            entity.Property(e => e.Codeid).HasColumnName("CODEID");
            entity.Property(e => e.Copaid).HasColumnName("COPAID");
            entity.Property(e => e.Copdcantidad).HasColumnName("COPDCantidad");
            entity.Property(e => e.CopdcentroCosto)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("COPDCentroCosto");
            entity.Property(e => e.Copdcuenta)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("COPDCuenta");
            entity.Property(e => e.Copddescuento)
                .HasColumnType("money")
                .HasColumnName("COPDDescuento");
            entity.Property(e => e.Copdglosa)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("COPDGlosa");
            entity.Property(e => e.Copdigv)
                .HasColumnType("money")
                .HasColumnName("COPDIGV");
            entity.Property(e => e.Copditem).HasColumnName("COPDItem");
            entity.Property(e => e.Copdprecio)
                .HasColumnType("money")
                .HasColumnName("COPDPrecio");
            entity.Property(e => e.Copdvencimiento).HasColumnName("COPDVencimiento");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Moneid).HasColumnName("MONEID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Code).WithMany(p => p.TcomprobantePagoDetalles)
                .HasForeignKey(d => d.Codeid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TComprobantePagoDetalle_TComprobanteDeuda");

            entity.HasOne(d => d.Copa).WithMany(p => p.TcomprobantePagoDetalles)
                .HasForeignKey(d => d.Copaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TComprobantePagoDetalle_TComprobantePagoCabecera");

            entity.HasOne(d => d.Mone).WithMany(p => p.TcomprobantePagoDetalles)
                .HasForeignKey(d => d.Moneid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TComprobantePagoDetalle_TSUNATTipoMoneda");
        });

        modelBuilder.Entity<TcomprobanteSerie>(entity =>
        {
            entity.HasKey(e => e.Seriid);

            entity.ToTable("TComprobanteSerie");

            entity.Property(e => e.Seriid).HasColumnName("SERIID");
            entity.Property(e => e.Seriestado).HasColumnName("SERIEstado");
            entity.Property(e => e.Serinombre)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERINombre");
            entity.Property(e => e.Seriserie)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SERISerie");
            entity.Property(e => e.Ticoid).HasColumnName("TICOID");

            entity.HasOne(d => d.Tico).WithMany(p => p.TcomprobanteSeries)
                .HasForeignKey(d => d.Ticoid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TComprobanteSerie_TSUNATTipoComprobante");
        });

        modelBuilder.Entity<Tdireccion>(entity =>
        {
            entity.HasKey(e => e.Direid);

            entity.ToTable("TDireccion");

            entity.Property(e => e.Direid)
                .ValueGeneratedNever()
                .HasColumnName("DIREID");
            entity.Property(e => e.CreatedBy).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Direcuadra)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DIRECuadra");
            entity.Property(e => e.Diredepartamento)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DIREDepartamento");
            entity.Property(e => e.Direedificio)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DIREEdificio");
            entity.Property(e => e.Direestado)
                .HasDefaultValue(true)
                .HasColumnName("DIREEstado");
            entity.Property(e => e.Direinterior)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DIREInterior");
            entity.Property(e => e.Direnombre)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("DIRENombre");
            entity.Property(e => e.Direnumero)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DIRENumero");
            entity.Property(e => e.Direobservaciones)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("DIREObservaciones");
            entity.Property(e => e.Direreferencia)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("DIREReferencia");
            entity.Property(e => e.DiresinNumero).HasColumnName("DIRESinNumero");
            entity.Property(e => e.DiretelefonoFijo)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("DIRETelefonoFijo");
            entity.Property(e => e.Ditiid).HasColumnName("DITIID");
            entity.Property(e => e.Ubigid).HasColumnName("UBIGID");
            entity.Property(e => e.UpdatedBy).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.HasOne(d => d.Diti).WithMany(p => p.Tdireccions)
                .HasForeignKey(d => d.Ditiid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TDireccion_TDireccionTipo");

            entity.HasOne(d => d.Ubig).WithMany(p => p.Tdireccions)
                .HasForeignKey(d => d.Ubigid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TDireccion_TUbigeo");
        });

        modelBuilder.Entity<TdireccionTipo>(entity =>
        {
            entity.HasKey(e => e.Ditiid);

            entity.ToTable("TDireccionTipo");

            entity.Property(e => e.Ditiid).HasColumnName("DITIID");
            entity.Property(e => e.Ditiabreviatura)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("DITIAbreviatura");
            entity.Property(e => e.Ditidescripcion)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("DITIDescripcion");
        });

        modelBuilder.Entity<Tempresa>(entity =>
        {
            entity.HasKey(e => e.Emprid);

            entity.ToTable("TEmpresa");

            entity.Property(e => e.Emprid)
                .ValueGeneratedNever()
                .HasColumnName("EMPRID");
            entity.Property(e => e.Direid).HasColumnName("DIREID");
            entity.Property(e => e.EmprnombreComercial)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("EMPRNombreComercial");
            entity.Property(e => e.EmprrazonSocial)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("EMPRRazonSocial");
            entity.Property(e => e.Emprruc)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("EMPRRUC");
            entity.Property(e => e.Emprsunatactivo)
                .HasDefaultValue(true)
                .HasColumnName("EMPRSUNATActivo");
            entity.Property(e => e.EmprtelefonoFijoCentral)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("EMPRTelefonoFijoCentral");
            entity.Property(e => e.Entiid).HasColumnName("ENTIID");
            entity.Property(e => e.Paisid).HasColumnName("PAISID");

            entity.HasOne(d => d.Dire).WithMany(p => p.Tempresas)
                .HasForeignKey(d => d.Direid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TEmpresa_TDireccion");

            entity.HasOne(d => d.Enti).WithMany(p => p.Tempresas)
                .HasForeignKey(d => d.Entiid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TEmpresa_TEntidad");

            entity.HasOne(d => d.Pais).WithMany(p => p.Tempresas)
                .HasForeignKey(d => d.Paisid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TEmpresa_TPais");
        });

        modelBuilder.Entity<Tentidad>(entity =>
        {
            entity.HasKey(e => e.Entiid);

            entity.ToTable("TEntidad");

            entity.Property(e => e.Entiid)
                .ValueGeneratedNever()
                .HasColumnName("ENTIID");
            entity.Property(e => e.Entiidentidad)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("ENTIIdentidad");
            entity.Property(e => e.Entinombre)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("ENTINombre");
            entity.Property(e => e.Entipersona).HasColumnName("ENTIPersona");
        });

        modelBuilder.Entity<TentidadDireccion>(entity =>
        {
            entity.HasKey(e => e.Endiid);

            entity.ToTable("TEntidadDireccion");

            entity.Property(e => e.Endiid)
                .ValueGeneratedNever()
                .HasColumnName("ENDIID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Direid).HasColumnName("DIREID");
            entity.Property(e => e.EndiprincipalLocal)
                .HasDefaultValue(true)
                .HasColumnName("ENDIPrincipalLocal");
            entity.Property(e => e.Endivigente)
                .HasDefaultValue(true)
                .HasColumnName("ENDIVigente");
            entity.Property(e => e.Entiid).HasColumnName("ENTIID");
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Dire).WithMany(p => p.TentidadDireccions)
                .HasForeignKey(d => d.Direid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TEntidadDireccion_TDireccion");

            entity.HasOne(d => d.Enti).WithMany(p => p.TentidadDireccions)
                .HasForeignKey(d => d.Entiid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TEntidadDireccion_TEntidad");
        });

        modelBuilder.Entity<TestadoCivil>(entity =>
        {
            entity.HasKey(e => e.Esciid);

            entity.ToTable("TEstadoCivil");

            entity.Property(e => e.Esciid).HasColumnName("ESCIID");
            entity.Property(e => e.Escidescripcion)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("ESCIDescripcion");
        });

        modelBuilder.Entity<ThistoricoServicio>(entity =>
        {
            entity.HasKey(e => e.Hsrvid);

            entity.ToTable("THistoricoServicio");

            entity.Property(e => e.Hsrvid).HasColumnName("HSRVID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Servabreviatura)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("SERVAbreviatura");
            entity.Property(e => e.ServafectoIgv).HasColumnName("SERVAfectoIGV");
            entity.Property(e => e.ServcantidadPaquete).HasColumnName("SERVCantidadPaquete");
            entity.Property(e => e.ServcentroCosto)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("SERVCentroCosto");
            entity.Property(e => e.ServcuentaActual)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("SERVCuentaActual");
            entity.Property(e => e.ServcuentaFutura)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("SERVCuentaFutura");
            entity.Property(e => e.ServcuentaPasada)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("SERVCuentaPasada");
            entity.Property(e => e.Servdescripcion)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("SERVDescripcion");
            entity.Property(e => e.Servdinamico).HasColumnName("SERVDinamico");
            entity.Property(e => e.Servestado).HasColumnName("SERVEstado");
            entity.Property(e => e.ServfechaFin).HasColumnName("SERVFechaFin");
            entity.Property(e => e.ServfechaInicio).HasColumnName("SERVFechaInicio");
            entity.Property(e => e.Servid).HasColumnName("SERVID");
            entity.Property(e => e.Servmensaje)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SERVMensaje");
            entity.Property(e => e.Servrestringido).HasColumnName("SERVRestringido");
            entity.Property(e => e.ServtarifaVigente)
                .HasColumnType("money")
                .HasColumnName("SERVTarifaVigente");
            entity.Property(e => e.ServvigenciaContinua).HasColumnName("SERVVigenciaContinua");
            entity.Property(e => e.Sutaid).HasColumnName("SUTAID");
            entity.Property(e => e.Suumid).HasColumnName("SUUMID");
            entity.Property(e => e.Svstid).HasColumnName("SVSTID");
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Serv).WithMany(p => p.ThistoricoServicios)
                .HasForeignKey(d => d.Servid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_THistoricoServicio_TServicio");
        });

        modelBuilder.Entity<TmetodoPago>(entity =>
        {
            entity.HasKey(e => e.Mepaid);

            entity.ToTable("TMetodoPago");

            entity.Property(e => e.Mepaid).HasColumnName("MEPAID");
            entity.Property(e => e.Enfiid).HasColumnName("ENFIID");
            entity.Property(e => e.Mdpaid).HasColumnName("MDPAID");
            entity.Property(e => e.Mepacodigo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MEPACodigo");
            entity.Property(e => e.Mepacuenta)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("MEPACuenta");
            entity.Property(e => e.Mepadescripcion)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("MEPADescripcion");
            entity.Property(e => e.Mepavisible)
                .HasDefaultValue(true)
                .HasColumnName("MEPAVisible");

            entity.HasOne(d => d.Enfi).WithMany(p => p.TmetodoPagos)
                .HasForeignKey(d => d.Enfiid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TMetodoPago_TSUNATEntidadFinanciera");

            entity.HasOne(d => d.Mdpa).WithMany(p => p.TmetodoPagos)
                .HasForeignKey(d => d.Mdpaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TMetodoPago_TSUNATMedioPago");
        });

        modelBuilder.Entity<Tocupacion>(entity =>
        {
            entity.HasKey(e => e.Ocupid);

            entity.ToTable("TOcupacion");

            entity.Property(e => e.Ocupid)
                .ValueGeneratedNever()
                .HasColumnName("OCUPID");
            entity.Property(e => e.Ocupabreviatura)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("OCUPAbreviatura");
            entity.Property(e => e.Ocupdescripcion)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("OCUPDescripcion");
        });

        modelBuilder.Entity<Tpago>(entity =>
        {
            entity.HasKey(e => e.Pagoid);

            entity.ToTable("TPago");

            entity.Property(e => e.Pagoid)
                .ValueGeneratedNever()
                .HasColumnName("PAGOID");
            entity.Property(e => e.Cajaid).HasColumnName("CAJAID");
            entity.Property(e => e.Copaid).HasColumnName("COPAID");
            entity.Property(e => e.CopamontoTotal)
                .HasColumnType("money")
                .HasColumnName("COPAMontoTotal");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Mepaid).HasColumnName("MEPAID");
            entity.Property(e => e.Moneid).HasColumnName("MONEID");
            entity.Property(e => e.Pagocuenta)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("PAGOCuenta");
            entity.Property(e => e.PagomontoPagado)
                .HasColumnType("money")
                .HasColumnName("PAGOMontoPagado");
            entity.Property(e => e.PagomontoRecibido)
                .HasColumnType("money")
                .HasColumnName("PAGOMontoRecibido");
            entity.Property(e => e.PagomontoRedondeo)
                .HasColumnType("money")
                .HasColumnName("PAGOMontoRedondeo");
            entity.Property(e => e.PagomontoVuelto)
                .HasColumnType("money")
                .HasColumnName("PAGOMontoVuelto");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Copa).WithMany(p => p.Tpagos)
                .HasForeignKey(d => d.Copaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPago_TComprobantePagoCabecera");

            entity.HasOne(d => d.Mepa).WithMany(p => p.Tpagos)
                .HasForeignKey(d => d.Mepaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPago_TMetodoPago");

            entity.HasOne(d => d.Mone).WithMany(p => p.Tpagos)
                .HasForeignKey(d => d.Moneid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPago_TSUNATTipoMoneda");
        });

        modelBuilder.Entity<Tpai>(entity =>
        {
            entity.HasKey(e => e.Paisid);

            entity.ToTable("TPais");

            entity.Property(e => e.Paisid).HasColumnName("PAISID");
            entity.Property(e => e.Paisalpha2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PAISAlpha2");
            entity.Property(e => e.PaiscodigoIso).HasColumnName("PAISCodigoISO");
            entity.Property(e => e.Paisdescripcion)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PAISDescripcion");
            entity.Property(e => e.Paisvisible).HasColumnName("PAISVisible");
        });

        modelBuilder.Entity<TparentescoTipo>(entity =>
        {
            entity.HasKey(e => e.Tiprid);

            entity.ToTable("TParentescoTipo");

            entity.Property(e => e.Tiprid).HasColumnName("TIPRID");
            entity.Property(e => e.Tiprabreviatura)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPRAbreviatura");
            entity.Property(e => e.Tiprdescripcion)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("TIPRDescripcion");
            entity.Property(e => e.Tiprmembresia).HasColumnName("TIPRMembresia");
        });

        modelBuilder.Entity<Tpermiso>(entity =>
        {
            entity.HasKey(e => e.Permid);

            entity.ToTable("TPermiso");

            entity.Property(e => e.Permid)
                .ValueGeneratedNever()
                .HasColumnName("PERMID");
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.Permdescripcion)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("PERMDescripcion");
            entity.Property(e => e.Permestado)
                .HasDefaultValue(true)
                .HasColumnName("PERMEstado");
            entity.Property(e => e.Permnombre)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PERMNombre");
            entity.Property(e => e.Tiprid).HasColumnName("TIPRID");
            entity.Property(e => e.UpdatedDate)
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.HasOne(d => d.Tipr).WithMany(p => p.Tpermisos)
                .HasForeignKey(d => d.Tiprid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPermiso_TPermiso");
        });

        modelBuilder.Entity<TpermisoTipo>(entity =>
        {
            entity.HasKey(e => e.Tiprid);

            entity.ToTable("TPermisoTipo");

            entity.Property(e => e.Tiprid).HasColumnName("TIPRID");
            entity.Property(e => e.Tiprdescripcion)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("TIPRDescripcion");
        });

        modelBuilder.Entity<Tpersona>(entity =>
        {
            entity.HasKey(e => e.Persid);

            entity.ToTable("TPersona");

            entity.Property(e => e.Persid).HasColumnName("PERSID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Entiid).HasColumnName("ENTIID");
            entity.Property(e => e.Paisid).HasColumnName("PAISID");
            entity.Property(e => e.PersactualizadoReniec).HasColumnName("PERSActualizadoReniec");
            entity.Property(e => e.Persapellido1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PERSApellido1");
            entity.Property(e => e.Persapellido2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PERSApellido2");
            entity.Property(e => e.Persdocumento)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("PERSDocumento");
            entity.Property(e => e.Persestado)
                .HasDefaultValue(true)
                .HasColumnName("PERSEstado");
            entity.Property(e => e.PersestadoCivil).HasColumnName("PERSEstadoCivil");
            entity.Property(e => e.PersfechaActualizacionReniec).HasColumnName("PERSFechaActualizacionReniec");
            entity.Property(e => e.PersfechaFallecimiento).HasColumnName("PERSFechaFallecimiento");
            entity.Property(e => e.PersfechaNacimiento).HasColumnName("PERSFechaNacimiento");
            entity.Property(e => e.PersfotoArchivo)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("PERSFotoArchivo");
            entity.Property(e => e.Persnombre1)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PERSNombre1");
            entity.Property(e => e.Persnombre2)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("PERSNombre2");
            entity.Property(e => e.Perssexo).HasColumnName("PERSSexo");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Enti).WithMany(p => p.Tpersonas)
                .HasForeignKey(d => d.Entiid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPersona_TEntidad");

            entity.HasOne(d => d.Pais).WithMany(p => p.Tpersonas)
                .HasForeignKey(d => d.Paisid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPersona_TPais");
        });

        modelBuilder.Entity<TpersonaCarnet>(entity =>
        {
            entity.HasKey(e => e.Pecaid);

            entity.ToTable("TPersonaCarnet");

            entity.Property(e => e.Pecaid).HasColumnName("PECAID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Pecaactivado).HasColumnName("PECAActivado");
            entity.Property(e => e.Pecacodigo)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("PECACodigo");
            entity.Property(e => e.Pecaestado).HasColumnName("PECAEstado");
            entity.Property(e => e.PecafechaEntrega).HasColumnName("PECAFechaEntrega");
            entity.Property(e => e.PecafechaImpresion).HasColumnName("PECAFechaImpresion");
            entity.Property(e => e.PecafechaInicio).HasColumnName("PECAFechaInicio");
            entity.Property(e => e.PecafechaVencimiento).HasColumnName("PECAFechaVencimiento");
            entity.Property(e => e.Persid).HasColumnName("PERSID");
            entity.Property(e => e.Ticaid).HasColumnName("TICAID");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Pers).WithMany(p => p.TpersonaCarnets)
                .HasForeignKey(d => d.Persid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPersonaCarnet_TPersona");

            entity.HasOne(d => d.Tica).WithMany(p => p.TpersonaCarnets)
                .HasForeignKey(d => d.Ticaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPersonaCarnet_TCarnetTipo");
        });

        modelBuilder.Entity<TpersonaParentesco>(entity =>
        {
            entity.HasKey(e => e.Persid).HasName("PK_TParentesco");

            entity.ToTable("TPersonaParentesco");

            entity.Property(e => e.Persid)
                .ValueGeneratedNever()
                .HasColumnName("PERSID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ParevalidezLegalMadre)
                .HasDefaultValue(true)
                .HasColumnName("PAREValidezLegalMadre");
            entity.Property(e => e.ParevalidezLegalPadre)
                .HasDefaultValue(true)
                .HasColumnName("PAREValidezLegalPadre");
            entity.Property(e => e.Persidmadre).HasColumnName("PERSIDMadre");
            entity.Property(e => e.Persidpadre).HasColumnName("PERSIDPadre");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Pers).WithOne(p => p.TpersonaParentescoPers)
                .HasForeignKey<TpersonaParentesco>(d => d.Persid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPersonaParentesco_TPersona");

            entity.HasOne(d => d.PersidmadreNavigation).WithMany(p => p.TpersonaParentescoPersidmadreNavigations)
                .HasForeignKey(d => d.Persidmadre)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPersonaParentesco_TPersona1");

            entity.HasOne(d => d.PersidpadreNavigation).WithMany(p => p.TpersonaParentescoPersidpadreNavigations)
                .HasForeignKey(d => d.Persidpadre)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPersonaParentesco_TPersona2");
        });

        modelBuilder.Entity<TpersonaSalud>(entity =>
        {
            entity.HasKey(e => e.Persid);

            entity.ToTable("TPersonaSalud");

            entity.Property(e => e.Persid)
                .ValueGeneratedNever()
                .HasColumnName("PERSID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PersfechaFallecimiento).HasColumnName("PERSFechaFallecimiento");
            entity.Property(e => e.PersfechaNacimiento).HasColumnName("PERSFechaNacimiento");
            entity.Property(e => e.Persidemergencia1).HasColumnName("PERSIDEmergencia1");
            entity.Property(e => e.Persidemergencia2).HasColumnName("PERSIDEmergencia2");
            entity.Property(e => e.Saluchequeo).HasColumnName("SALUChequeo");
            entity.Property(e => e.Saluddjjcoronavirus).HasColumnName("SALUDDJJCoronavirus");
            entity.Property(e => e.Saludiscapacidad).HasColumnName("SALUDiscapacidad");
            entity.Property(e => e.Saluobservaciones)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("SALUObservaciones");
            entity.Property(e => e.Salupersonalidad)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SALUPersonalidad");
            entity.Property(e => e.SalutipoSangre)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SALUTipoSangre");
            entity.Property(e => e.UbigidciudadNacimiento).HasColumnName("UBIGIDCiudadNacimiento");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Pers).WithOne(p => p.TpersonaSaludPers)
                .HasForeignKey<TpersonaSalud>(d => d.Persid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPersonaSalud_TPersona");

            entity.HasOne(d => d.Persidemergencia1Navigation).WithMany(p => p.TpersonaSaludPersidemergencia1Navigations)
                .HasForeignKey(d => d.Persidemergencia1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPersonaSalud_TPersona1");

            entity.HasOne(d => d.Persidemergencia2Navigation).WithMany(p => p.TpersonaSaludPersidemergencia2Navigations)
                .HasForeignKey(d => d.Persidemergencia2)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPersonaSalud_TPersona2");
        });

        modelBuilder.Entity<TpersonaTipo>(entity =>
        {
            entity.HasKey(e => e.Tipeid);

            entity.ToTable("TPersonaTipo");

            entity.Property(e => e.Tipeid).HasColumnName("TIPEID");
            entity.Property(e => e.Tipeabreviatura)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TIPEAbreviatura");
            entity.Property(e => e.Tipedescripcion)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("TIPEDescripcion");
        });

        modelBuilder.Entity<TpersonaTrabajo>(entity =>
        {
            entity.HasKey(e => new { e.Persid, e.PersidentidadTrabajo });

            entity.ToTable("TPersonaTrabajo");

            entity.Property(e => e.Persid).HasColumnName("PERSID");
            entity.Property(e => e.PersidentidadTrabajo).HasColumnName("PERSIDEntidadTrabajo");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Ocupid).HasColumnName("OCUPID");
            entity.Property(e => e.PetranexoOficina)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("PETRAnexoOficina");
            entity.Property(e => e.PetrcelularOficina)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("PETRCelularOficina");
            entity.Property(e => e.Petrvigente).HasColumnName("PETRVigente");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Ocup).WithMany(p => p.TpersonaTrabajos)
                .HasForeignKey(d => d.Ocupid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPersonaTrabajo_TOcupacion");

            entity.HasOne(d => d.Pers).WithMany(p => p.TpersonaTrabajoPers)
                .HasForeignKey(d => d.Persid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPersonaTrabajo_TPersona");

            entity.HasOne(d => d.PersidentidadTrabajoNavigation).WithMany(p => p.TpersonaTrabajoPersidentidadTrabajoNavigations)
                .HasForeignKey(d => d.PersidentidadTrabajo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TPersonaTrabajo_TPersona1");
        });

        modelBuilder.Entity<TplantillaDeudum>(entity =>
        {
            entity.HasKey(e => e.Plaid).HasName("PK__TPlantil__E44130C929C74174");

            entity.ToTable("TPlantillaDeuda");

            entity.Property(e => e.Plaid).HasColumnName("PLAID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Persid).HasColumnName("PERSID");
            entity.Property(e => e.Plaestado).HasColumnName("PLAEstado");
            entity.Property(e => e.PlafechaFin)
                .HasColumnType("datetime")
                .HasColumnName("PLAFechaFin");
            entity.Property(e => e.PlafechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("PLAFechaInicio");
            entity.Property(e => e.Plafrecuencia).HasColumnName("PLAFrecuencia");
            entity.Property(e => e.Servid).HasColumnName("SERVID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Pers).WithMany(p => p.TplantillaDeuda)
                .HasForeignKey(d => d.Persid)
                .HasConstraintName("FK_TPlantilaDeuda_Persona");

            entity.HasOne(d => d.Serv).WithMany(p => p.TplantillaDeuda)
                .HasForeignKey(d => d.Servid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_TPlantillaDeuda_TServicio_1");
        });

        modelBuilder.Entity<TplantillaTurnoCaja>(entity =>
        {
            entity.HasKey(e => e.Ptcjid);

            entity.ToTable("TPlantillaTurnoCaja");

            entity.Property(e => e.Ptcjid)
                .ValueGeneratedNever()
                .HasColumnName("PTCJID");
            entity.Property(e => e.Cajaid).HasColumnName("CAJAID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PtcjdiaSemana).HasColumnName("PTCJDiaSemana");
            entity.Property(e => e.PtcjhoraFin)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PTCJHoraFin");
            entity.Property(e => e.PtcjhoraInicio)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("PTCJHoraInicio");
            entity.Property(e => e.Ptcjmedianoche).HasColumnName("PTCJMedianoche");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Trol>(entity =>
        {
            entity.HasKey(e => e.Roleid);

            entity.ToTable("TRol");

            entity.Property(e => e.Roleid).HasColumnName("ROLEID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Roledescripcion)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("ROLEDescripcion");
            entity.Property(e => e.Roleestado)
                .HasDefaultValue(true)
                .HasColumnName("ROLEEstado");
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Tservicio>(entity =>
        {
            entity.HasKey(e => e.Servid);

            entity.ToTable("TServicio", tb => tb.HasTrigger("Trigger_TServicio_Update"));

            entity.HasIndex(e => e.Servdescripcion, "IX_TServicio").IsUnique();

            entity.Property(e => e.Servid).HasColumnName("SERVID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Servabreviatura)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SERVAbreviatura");
            entity.Property(e => e.ServafectoIgv)
                .HasDefaultValue(true)
                .HasColumnName("SERVAfectoIGV");
            entity.Property(e => e.ServcantidadPaquete)
                .HasDefaultValue((byte)1)
                .HasColumnName("SERVCantidadPaquete");
            entity.Property(e => e.ServcentroCosto)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("SERVCentroCosto");
            entity.Property(e => e.ServcuentaActual)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("SERVCuentaActual");
            entity.Property(e => e.ServcuentaFutura)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("SERVCuentaFutura");
            entity.Property(e => e.ServcuentaPasada)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("SERVCuentaPasada");
            entity.Property(e => e.Servdescripcion)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("SERVDescripcion");
            entity.Property(e => e.Servdinamico)
                .HasDefaultValue(true)
                .HasColumnName("SERVDinamico");
            entity.Property(e => e.Servestado)
                .HasDefaultValue(true)
                .HasColumnName("SERVEstado");
            entity.Property(e => e.ServfechaFin).HasColumnName("SERVFechaFin");
            entity.Property(e => e.ServfechaInicio).HasColumnName("SERVFechaInicio");
            entity.Property(e => e.Servmensaje)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SERVMensaje");
            entity.Property(e => e.Servrestringido).HasColumnName("SERVRestringido");
            entity.Property(e => e.ServtarifaVigente)
                .HasColumnType("money")
                .HasColumnName("SERVTarifaVigente");
            entity.Property(e => e.ServvigenciaContinua).HasColumnName("SERVVigenciaContinua");
            entity.Property(e => e.Sutaid).HasColumnName("SUTAID");
            entity.Property(e => e.Suumid).HasColumnName("SUUMID");
            entity.Property(e => e.Svstid).HasColumnName("SVSTID");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Suta).WithMany(p => p.Tservicios)
                .HasForeignKey(d => d.Sutaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TServicio_TSUNATTipoAfectacion");

            entity.HasOne(d => d.Suum).WithMany(p => p.Tservicios)
                .HasForeignKey(d => d.Suumid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TServicio_TSUNATUnidadMedida");

            entity.HasOne(d => d.Svst).WithMany(p => p.Tservicios)
                .HasForeignKey(d => d.Svstid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TServicio_TServicioTipo");
        });

        modelBuilder.Entity<TservicioTipo>(entity =>
        {
            entity.HasKey(e => e.Svstid);

            entity.ToTable("TServicioTipo");

            entity.Property(e => e.Svstid)
                .ValueGeneratedOnAdd()
                .HasColumnName("SVSTID");
            entity.Property(e => e.Svstdescripcion)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("SVSTDescripcion");
        });

        modelBuilder.Entity<Tsocio>(entity =>
        {
            entity.HasKey(e => e.Sociid);

            entity.ToTable("TSocio");

            entity.Property(e => e.Sociid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SOCIID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Persidpresentador1).HasColumnName("PERSIDPresentador1");
            entity.Property(e => e.Persidpresentador2).HasColumnName("PERSIDPresentador2");
            entity.Property(e => e.Persidtitular).HasColumnName("PERSIDTitular");
            entity.Property(e => e.Sociestado)
                .HasDefaultValue(true)
                .HasComment("Se permite o no operaciones, caso fallecido con hijos menores activos")
                .HasColumnName("SOCIEstado");
            entity.Property(e => e.SocifechaAdmision).HasColumnName("SOCIFechaAdmision");
            entity.Property(e => e.SocifechaConteo).HasColumnName("SOCIFechaConteo");
            entity.Property(e => e.SocifechaVencimiento).HasColumnName("SOCIFechaVencimiento");
            entity.Property(e => e.SocimesesDeuda).HasColumnName("SOCIMesesDeuda");
            entity.Property(e => e.Soeeid).HasColumnName("SOEEID");
            entity.Property(e => e.Steeid).HasColumnName("STEEID");
            entity.Property(e => e.Tisoid).HasColumnName("TISOID");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Persidpresentador1Navigation).WithMany(p => p.TsocioPersidpresentador1Navigations)
                .HasForeignKey(d => d.Persidpresentador1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TSocio_TPersona1");

            entity.HasOne(d => d.Persidpresentador2Navigation).WithMany(p => p.TsocioPersidpresentador2Navigations)
                .HasForeignKey(d => d.Persidpresentador2)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TSocio_TPersona2");

            entity.HasOne(d => d.PersidtitularNavigation).WithMany(p => p.TsocioPersidtitularNavigations)
                .HasForeignKey(d => d.Persidtitular)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TSocio_TPersona");

            entity.HasOne(d => d.Soee).WithMany(p => p.Tsocios)
                .HasForeignKey(d => d.Soeeid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TSocio_TSocioEstadoEstatutario");

            entity.HasOne(d => d.Stee).WithMany(p => p.Tsocios)
                .HasForeignKey(d => d.Steeid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TSocio_TSocioTipoEstadoEspecial");

            entity.HasOne(d => d.Tiso).WithMany(p => p.Tsocios)
                .HasForeignKey(d => d.Tisoid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TSocio_TSocioTipo");
        });

        modelBuilder.Entity<TsocioBeneficioMatrimonio>(entity =>
        {
            entity.HasKey(e => e.Bmeaid);

            entity.ToTable("TSocioBeneficioMatrimonio");

            entity.Property(e => e.Bmeaid).HasColumnName("BMEAID");
            entity.Property(e => e.BmeafechaAprobacion).HasColumnName("BMEAFechaAprobacion");
            entity.Property(e => e.BmeafechaTermino).HasColumnName("BMEAFechaTermino");
            entity.Property(e => e.Bmeavigente)
                .HasDefaultValue(true)
                .HasColumnName("BMEAVigente");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.SociidconyugeF)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SOCIIDConyugeF");
            entity.Property(e => e.SociidconyugeM)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SOCIIDConyugeM");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.SociidconyugeFNavigation).WithMany(p => p.TsocioBeneficioMatrimonioSociidconyugeFNavigations)
                .HasForeignKey(d => d.SociidconyugeF)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TSocioBeneficioMatrimonio_TSocio");

            entity.HasOne(d => d.SociidconyugeMNavigation).WithMany(p => p.TsocioBeneficioMatrimonioSociidconyugeMNavigations)
                .HasForeignKey(d => d.SociidconyugeM)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TSocioBeneficioMatrimonio_TSocio1");
        });

        modelBuilder.Entity<TsocioEstadoAdministrativo>(entity =>
        {
            entity.HasKey(e => e.Soeaid);

            entity.ToTable("TSocioEstadoAdministrativo");

            entity.Property(e => e.Soeaid).HasColumnName("SOEAID");
            entity.Property(e => e.Soeaabreviatura)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SOEAAbreviatura");
            entity.Property(e => e.Soeadescripcion)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("SOEADescripcion");
        });

        modelBuilder.Entity<TsocioEstadoEstatutario>(entity =>
        {
            entity.HasKey(e => e.Soeeid);

            entity.ToTable("TSocioEstadoEstatutario");

            entity.Property(e => e.Soeeid).HasColumnName("SOEEID");
            entity.Property(e => e.Soeeabreviatura)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SOEEAbreviatura");
            entity.Property(e => e.Soeedescripcion)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("SOEEDescripcion");
        });

        modelBuilder.Entity<TsocioGrupoFamiliar>(entity =>
        {
            entity.HasKey(e => new { e.Sociid, e.Persid });

            entity.ToTable("TSocioGrupoFamiliar");

            entity.Property(e => e.Sociid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SOCIID");
            entity.Property(e => e.Persid).HasColumnName("PERSID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Soeaid).HasColumnName("SOEAID");
            entity.Property(e => e.Sogfestado)
                .HasDefaultValue(true)
                .HasColumnName("SOGFEstado");
            entity.Property(e => e.SogffechaVencimiento).HasColumnName("SOGFFechaVencimiento");
            entity.Property(e => e.Sogfoculto).HasColumnName("SOGFOculto");
            entity.Property(e => e.Tiprid).HasColumnName("TIPRID");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Pers).WithMany(p => p.TsocioGrupoFamiliars)
                .HasForeignKey(d => d.Persid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TSocioGrupoFamiliar_TPersona");

            entity.HasOne(d => d.Soci).WithMany(p => p.TsocioGrupoFamiliars)
                .HasForeignKey(d => d.Sociid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TSocioGrupoFamiliar_TSocio");

            entity.HasOne(d => d.Soea).WithMany(p => p.TsocioGrupoFamiliars)
                .HasForeignKey(d => d.Soeaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TSocioGrupoFamiliar_TSocioEstadoAdministrativo");

            entity.HasOne(d => d.Tipr).WithMany(p => p.TsocioGrupoFamiliars)
                .HasForeignKey(d => d.Tiprid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TSocioGrupoFamiliar_TParentescoTipo");
        });

        modelBuilder.Entity<TsocioMovimiento>(entity =>
        {
            entity.HasKey(e => e.Movsid);

            entity.ToTable("TSocioMovimiento");

            entity.Property(e => e.Movsid).HasColumnName("MOVSID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Movsanulado).HasColumnName("MOVSAnulado");
            entity.Property(e => e.Movsestado)
                .HasDefaultValue(true)
                .HasColumnName("MOVSEstado");
            entity.Property(e => e.Movsfecha).HasColumnName("MOVSFecha");
            entity.Property(e => e.Movsidanulante).HasColumnName("MOVSIDAnulante");
            entity.Property(e => e.Sociid)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SOCIID");
            entity.Property(e => e.Timsid).HasColumnName("TIMSID");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Soci).WithMany(p => p.TsocioMovimientos)
                .HasForeignKey(d => d.Sociid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TSocioMovimiento_TSocio");

            entity.HasOne(d => d.Tims).WithMany(p => p.TsocioMovimientos)
                .HasForeignKey(d => d.Timsid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TSocioMovimiento_TSocioMovimientoTipo");
        });

        modelBuilder.Entity<TsocioMovimientoTipo>(entity =>
        {
            entity.HasKey(e => e.Timsid);

            entity.ToTable("TSocioMovimientoTipo");

            entity.Property(e => e.Timsid).HasColumnName("TIMSID");
            entity.Property(e => e.Timsdescripcion)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("TIMSDescripcion");
            entity.Property(e => e.Timsidanulante).HasColumnName("TIMSIDAnulante");
        });

        modelBuilder.Entity<TsocioTipo>(entity =>
        {
            entity.HasKey(e => e.Tisoid);

            entity.ToTable("TSocioTipo");

            entity.Property(e => e.Tisoid).HasColumnName("TISOID");
            entity.Property(e => e.Tisoabreviatura)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TISOAbreviatura");
            entity.Property(e => e.Tisodescripcion)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("TISODescripcion");
        });

        modelBuilder.Entity<TsocioTipoEstadoEspecial>(entity =>
        {
            entity.HasKey(e => e.Steeid).HasName("PK_TSocioEstadoEspecial");

            entity.ToTable("TSocioTipoEstadoEspecial");

            entity.Property(e => e.Steeid).HasColumnName("STEEID");
            entity.Property(e => e.Steedescripcion)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("STEEDescripcion");
        });

        modelBuilder.Entity<TsunatentidadFinanciera>(entity =>
        {
            entity.HasKey(e => e.Enfiid);

            entity.ToTable("TSUNATEntidadFinanciera");

            entity.Property(e => e.Enfiid).HasColumnName("ENFIID");
            entity.Property(e => e.Enfinombre)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ENFINombre");
            entity.Property(e => e.EnfinombreCorto)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ENFINombreCorto");
            entity.Property(e => e.Enfivisible).HasColumnName("ENFIVisible");
        });

        modelBuilder.Entity<TsunatmedioPago>(entity =>
        {
            entity.HasKey(e => e.Mdpaid);

            entity.ToTable("TSUNATMedioPago");

            entity.Property(e => e.Mdpaid)
                .ValueGeneratedNever()
                .HasColumnName("MDPAID");
            entity.Property(e => e.Mdpanombre)
                .HasMaxLength(187)
                .IsUnicode(false)
                .HasColumnName("MDPANombre");
            entity.Property(e => e.MdpanombreCorto)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("MDPANombreCorto");
            entity.Property(e => e.Mdpavisible).HasColumnName("MDPAVisible");
        });

        modelBuilder.Entity<TsunattipoAfectacion>(entity =>
        {
            entity.HasKey(e => e.Sutaid);

            entity.ToTable("TSUNATTipoAfectacion");

            entity.Property(e => e.Sutaid).HasColumnName("SUTAID");
            entity.Property(e => e.Sutadescripcion)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SUTADescripcion");
            entity.Property(e => e.Sutavisible).HasColumnName("SUTAVisible");
        });

        modelBuilder.Entity<TsunattipoComprobante>(entity =>
        {
            entity.HasKey(e => e.Ticoid);

            entity.ToTable("TSUNATTipoComprobante");

            entity.Property(e => e.Ticoid).HasColumnName("TICOID");
            entity.Property(e => e.Ticonombre)
                .HasMaxLength(331)
                .IsUnicode(false)
                .HasColumnName("TICONombre");
            entity.Property(e => e.Ticovisible).HasColumnName("TICOVisible");
        });

        modelBuilder.Entity<TsunattipoDocumentoIdentidad>(entity =>
        {
            entity.HasKey(e => e.Stdiid);

            entity.ToTable("TSUNATTipoDocumentoIdentidad");

            entity.Property(e => e.Stdiid).HasColumnName("STDIID");
            entity.Property(e => e.Stdiabreviatura)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("STDIAbreviatura");
            entity.Property(e => e.Stdicodigo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("STDICodigo");
            entity.Property(e => e.Stdidescripcion)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("STDIDescripcion");
            entity.Property(e => e.Stdivisible)
                .HasDefaultValue(true)
                .HasColumnName("STDIVisible");
        });

        modelBuilder.Entity<TsunattipoMonedum>(entity =>
        {
            entity.HasKey(e => e.Moneid);

            entity.ToTable("TSUNATTipoMoneda");

            entity.Property(e => e.Moneid).HasColumnName("MONEID");
            entity.Property(e => e.Moneisocodigo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("MONEISOCodigo");
            entity.Property(e => e.Moneisonumero).HasColumnName("MONEISONumero");
            entity.Property(e => e.Monenombre)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("MONENombre");
            entity.Property(e => e.Monesimbolo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("MONESimbolo");
        });

        modelBuilder.Entity<TsunattipoNotaCredito>(entity =>
        {
            entity.HasKey(e => e.Tnceid);

            entity.ToTable("TSUNATTipoNotaCredito");

            entity.Property(e => e.Tnceid).HasColumnName("TNCEID");
            entity.Property(e => e.Tncedescripcion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("TNCEDescripcion");
            entity.Property(e => e.Tncevisible).HasColumnName("TNCEVisible");
        });

        modelBuilder.Entity<TsunatunidadMedidum>(entity =>
        {
            entity.HasKey(e => e.Suumid);

            entity.ToTable("TSUNATUnidadMedida");

            entity.Property(e => e.Suumid)
                .ValueGeneratedOnAdd()
                .HasColumnName("SUUMID");
            entity.Property(e => e.Suumcodigo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SUUMCodigo");
            entity.Property(e => e.Suumdescripcion)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("SUUMDescripcion");
            entity.Property(e => e.Suumvisible).HasColumnName("SUUMVisible");
        });

        modelBuilder.Entity<TtablaMini>(entity =>
        {
            entity.HasKey(e => e.Tablid);

            entity.ToTable("TTablaMini");

            entity.Property(e => e.Tablid).HasColumnName("TABLID");
            entity.Property(e => e.Tablcodigo).HasColumnName("TABLCodigo");
            entity.Property(e => e.Tablnombre)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("TABLNombre");
            entity.Property(e => e.Tabltipo)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("TABLTipo");
        });

        modelBuilder.Entity<TturnoCaja>(entity =>
        {
            entity.HasKey(e => e.Tucaid);

            entity.ToTable("TTurnoCaja");

            entity.Property(e => e.Tucaid)
                .ValueGeneratedNever()
                .HasColumnName("TUCAID");
            entity.Property(e => e.Ptcjid).HasColumnName("PTCJID");
            entity.Property(e => e.Tucaapertura)
                .HasColumnType("datetime")
                .HasColumnName("TUCAApertura");
            entity.Property(e => e.Tucacerrado).HasColumnName("TUCACerrado");
            entity.Property(e => e.Tucacierre)
                .HasColumnType("datetime")
                .HasColumnName("TUCACierre");
            entity.Property(e => e.Tucafecha).HasColumnName("TUCAFecha");
            entity.Property(e => e.Userid).HasColumnName("USERID");

            entity.HasOne(d => d.Ptcj).WithMany(p => p.TturnoCajas)
                .HasForeignKey(d => d.Ptcjid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TTurnoCaja_TPlantillaTurnoCaja");

            entity.HasOne(d => d.User).WithMany(p => p.TturnoCajas)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TTurnoCaja_TUsuario");
        });

        modelBuilder.Entity<Tubigeo>(entity =>
        {
            entity.HasKey(e => e.Ubigid);

            entity.ToTable("TUbigeo");

            entity.Property(e => e.Ubigid).HasColumnName("UBIGID");
            entity.Property(e => e.Paisid).HasColumnName("PAISID");
            entity.Property(e => e.UbigcapitalLegal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UBIGCapitalLegal");
            entity.Property(e => e.Ubigcodigo)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UBIGCodigo");
            entity.Property(e => e.Ubigdepartamento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UBIGDepartamento");
            entity.Property(e => e.Ubigdistrito)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UBIGDistrito");
            entity.Property(e => e.Ubigprovincia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UBIGProvincia");
            entity.Property(e => e.Ubigvisible).HasColumnName("UBIGVisible");

            entity.HasOne(d => d.Pais).WithMany(p => p.Tubigeos)
                .HasForeignKey(d => d.Paisid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TUbigeo_TPais");
        });

        modelBuilder.Entity<Tusuario>(entity =>
        {
            entity.HasKey(e => e.Userid);

            entity.ToTable("TUsuario");

            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Persid).HasColumnName("PERSID");
            entity.Property(e => e.Roleid).HasColumnName("ROLEID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserbloqueoTemporal).HasColumnName("USERBloqueoTemporal");
            entity.Property(e => e.UsercambiarContrasena)
                .HasDefaultValue(true)
                .HasColumnName("USERCambiarContrasena");
            entity.Property(e => e.Usercontrasena)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("USERContrasena");
            entity.Property(e => e.Usercorreo)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("USERCorreo");
            entity.Property(e => e.Userestado)
                .HasDefaultValue(true)
                .HasColumnName("USEREstado");
            entity.Property(e => e.UserfechaEnvioToken)
                .HasColumnType("datetime")
                .HasColumnName("USERFechaEnvioToken");
            entity.Property(e => e.UserinicioSesion)
                .HasColumnType("datetime")
                .HasColumnName("USERInicioSesion");
            entity.Property(e => e.Userinterno)
                .HasDefaultValue(true)
                .HasColumnName("USERInterno");
            entity.Property(e => e.Userpermanente)
                .HasDefaultValue(true)
                .HasColumnName("USERPermanente");
            entity.Property(e => e.UsertokenConfirmacion)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("USERTokenConfirmacion");
            entity.Property(e => e.Userusuario)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("USERUsuario");
            entity.Property(e => e.Uservencimiento)
                .HasDefaultValueSql("((0))")
                .HasColumnType("datetime")
                .HasColumnName("USERVencimiento");

            entity.HasOne(d => d.Pers).WithMany(p => p.Tusuarios)
                .HasForeignKey(d => d.Persid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TUsuario_TPersona");

            entity.HasOne(d => d.Role).WithMany(p => p.Tusuarios)
                .HasForeignKey(d => d.Roleid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TUsuario_TRol");
        });

        modelBuilder.Entity<TusuarioLog>(entity =>
        {
            entity.HasKey(e => e.Loguid);

            entity.ToTable("TUsuarioLog");

            entity.Property(e => e.Loguid).HasColumnName("LOGUID");
            entity.Property(e => e.LoguinicioExitoso).HasColumnName("LOGUInicioExitoso");
            entity.Property(e => e.LogusesionVigente)
                .HasDefaultValue(true)
                .HasColumnName("LOGUSesionVigente");
            entity.Property(e => e.LoguultimoIntento)
                .HasColumnType("datetime")
                .HasColumnName("LOGUUltimoIntento");
            entity.Property(e => e.Userid).HasColumnName("USERID");

            entity.HasOne(d => d.User).WithMany(p => p.TusuarioLogs)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TUsuarioLog_TUsuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
