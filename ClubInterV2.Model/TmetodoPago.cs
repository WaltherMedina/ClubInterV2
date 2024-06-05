using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TmetodoPago
{
    public byte Mepaid { get; set; }

    public short Mdpaid { get; set; }

    public byte Enfiid { get; set; }

    public string Mepacodigo { get; set; } = null!;

    public string Mepadescripcion { get; set; } = null!;

    public string Mepacuenta { get; set; } = null!;

    public bool Mepavisible { get; set; }

    public virtual TsunatentidadFinanciera Enfi { get; set; } = null!;

    public virtual TsunatmedioPago Mdpa { get; set; } = null!;

    public virtual ICollection<TcajaConciliacionDetalleMetodoPago> TcajaConciliacionDetalleMetodoPagos { get; set; } = new List<TcajaConciliacionDetalleMetodoPago>();

    public virtual ICollection<Tpago> Tpagos { get; set; } = new List<Tpago>();
}
