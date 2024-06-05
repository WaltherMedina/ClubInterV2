using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TsunatmedioPago
{
    public short Mdpaid { get; set; }

    public string Mdpanombre { get; set; } = null!;

    public bool Mdpavisible { get; set; }

    public string MdpanombreCorto { get; set; } = null!;

    public virtual ICollection<TmetodoPago> TmetodoPagos { get; set; } = new List<TmetodoPago>();
}
