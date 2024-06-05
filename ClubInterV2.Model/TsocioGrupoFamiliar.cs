using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TsocioGrupoFamiliar
{
    public string Sociid { get; set; } = null!;

    public int Persid { get; set; }

    public byte Tiprid { get; set; }

    public byte Soeaid { get; set; }

    public bool Sogfoculto { get; set; }

    public bool Sogfestado { get; set; }

    public DateOnly SogffechaVencimiento { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public virtual Tpersona Pers { get; set; } = null!;

    public virtual Tsocio Soci { get; set; } = null!;

    public virtual TsocioEstadoAdministrativo Soea { get; set; } = null!;

    public virtual TparentescoTipo Tipr { get; set; } = null!;
}
