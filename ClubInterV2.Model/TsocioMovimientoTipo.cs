using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TsocioMovimientoTipo
{
    public byte Timsid { get; set; }

    public string Timsdescripcion { get; set; } = null!;

    public byte Timsidanulante { get; set; }

    public virtual ICollection<TsocioMovimiento> TsocioMovimientos { get; set; } = new List<TsocioMovimiento>();
}
