using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TsocioMovimiento
{
    public int Movsid { get; set; }

    public string Sociid { get; set; } = null!;

    public byte Timsid { get; set; }

    public DateOnly Movsfecha { get; set; }

    public bool Movsanulado { get; set; }

    public byte Movsidanulante { get; set; }

    public bool Movsestado { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public virtual Tsocio Soci { get; set; } = null!;

    public virtual TsocioMovimientoTipo Tims { get; set; } = null!;
}
