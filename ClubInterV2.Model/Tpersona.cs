using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class Tpersona
{
    public int Persid { get; set; }

    public int Entiid { get; set; }

    public string Persdocumento { get; set; } = null!;

    public byte Paisid { get; set; }

    public string Persnombre1 { get; set; } = null!;

    public string Persnombre2 { get; set; } = null!;

    public string Persapellido1 { get; set; } = null!;

    public string Persapellido2 { get; set; } = null!;

    public byte Perssexo { get; set; }

    public DateOnly PersfechaNacimiento { get; set; }

    public DateOnly PersfechaFallecimiento { get; set; }

    public bool Persestado { get; set; }

    public byte PersestadoCivil { get; set; }

    public string PersfotoArchivo { get; set; } = null!;

    public bool PersactualizadoReniec { get; set; }

    public DateOnly PersfechaActualizacionReniec { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public virtual Tentidad Enti { get; set; } = null!;

    public virtual Tpai Pais { get; set; } = null!;

    public virtual ICollection<TpersonaCarnet> TpersonaCarnets { get; set; } = new List<TpersonaCarnet>();

    public virtual TpersonaParentesco? TpersonaParentescoPers { get; set; }

    public virtual ICollection<TpersonaParentesco> TpersonaParentescoPersidmadreNavigations { get; set; } = new List<TpersonaParentesco>();

    public virtual ICollection<TpersonaParentesco> TpersonaParentescoPersidpadreNavigations { get; set; } = new List<TpersonaParentesco>();

    public virtual TpersonaSalud? TpersonaSaludPers { get; set; }

    public virtual ICollection<TpersonaSalud> TpersonaSaludPersidemergencia1Navigations { get; set; } = new List<TpersonaSalud>();

    public virtual ICollection<TpersonaSalud> TpersonaSaludPersidemergencia2Navigations { get; set; } = new List<TpersonaSalud>();

    public virtual ICollection<TpersonaTrabajo> TpersonaTrabajoPers { get; set; } = new List<TpersonaTrabajo>();

    public virtual ICollection<TpersonaTrabajo> TpersonaTrabajoPersidentidadTrabajoNavigations { get; set; } = new List<TpersonaTrabajo>();

    public virtual ICollection<TplantillaDeudum> TplantillaDeuda { get; set; } = new List<TplantillaDeudum>();

    public virtual ICollection<TsocioGrupoFamiliar> TsocioGrupoFamiliars { get; set; } = new List<TsocioGrupoFamiliar>();

    public virtual ICollection<Tsocio> TsocioPersidpresentador1Navigations { get; set; } = new List<Tsocio>();

    public virtual ICollection<Tsocio> TsocioPersidpresentador2Navigations { get; set; } = new List<Tsocio>();

    public virtual ICollection<Tsocio> TsocioPersidtitularNavigations { get; set; } = new List<Tsocio>();

    public virtual ICollection<Tusuario> Tusuarios { get; set; } = new List<Tusuario>();
}
