using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class Tsocio
{
    public string Sociid { get; set; } = null!;

    public int Persidtitular { get; set; }

    public byte Tisoid { get; set; }

    public byte Soeeid { get; set; }

    public byte Steeid { get; set; }

    public int Persidpresentador1 { get; set; }

    public int Persidpresentador2 { get; set; }

    public DateOnly SocifechaConteo { get; set; }

    public DateOnly SocifechaAdmision { get; set; }

    public DateOnly SocifechaVencimiento { get; set; }

    /// <summary>
    /// Se permite o no operaciones, caso fallecido con hijos menores activos
    /// </summary>
    public bool Sociestado { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public short SocimesesDeuda { get; set; }

    public virtual Tpersona Persidpresentador1Navigation { get; set; } = null!;

    public virtual Tpersona Persidpresentador2Navigation { get; set; } = null!;

    public virtual Tpersona PersidtitularNavigation { get; set; } = null!;

    public virtual TsocioEstadoEstatutario Soee { get; set; } = null!;

    public virtual TsocioTipoEstadoEspecial Stee { get; set; } = null!;

    public virtual TsocioTipo Tiso { get; set; } = null!;

    public virtual ICollection<TsocioBeneficioMatrimonio> TsocioBeneficioMatrimonioSociidconyugeFNavigations { get; set; } = new List<TsocioBeneficioMatrimonio>();

    public virtual ICollection<TsocioBeneficioMatrimonio> TsocioBeneficioMatrimonioSociidconyugeMNavigations { get; set; } = new List<TsocioBeneficioMatrimonio>();

    public virtual ICollection<TsocioGrupoFamiliar> TsocioGrupoFamiliars { get; set; } = new List<TsocioGrupoFamiliar>();

    public virtual ICollection<TsocioMovimiento> TsocioMovimientos { get; set; } = new List<TsocioMovimiento>();
}
