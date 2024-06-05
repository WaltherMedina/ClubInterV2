using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TpersonaCarnet
{
    public int Pecaid { get; set; }

    public int Persid { get; set; }

    public byte Ticaid { get; set; }

    public bool Pecaactivado { get; set; }

    public string Pecacodigo { get; set; } = null!;

    public DateOnly PecafechaInicio { get; set; }

    public DateOnly PecafechaVencimiento { get; set; }

    public DateOnly PecafechaImpresion { get; set; }

    public DateOnly PecafechaEntrega { get; set; }

    public bool Pecaestado { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public virtual Tpersona Pers { get; set; } = null!;

    public virtual TcarnetTipo Tica { get; set; } = null!;
}
