using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TsunatentidadFinanciera
{
    public byte Enfiid { get; set; }

    public string Enfinombre { get; set; } = null!;

    public bool Enfivisible { get; set; }

    public string EnfinombreCorto { get; set; } = null!;

    public virtual ICollection<TmetodoPago> TmetodoPagos { get; set; } = new List<TmetodoPago>();
}
