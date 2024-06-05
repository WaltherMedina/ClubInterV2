using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TcajaConciliacionDetalleMetodoPago
{
    public int Ccdmid { get; set; }

    public int Concid { get; set; }

    public byte Mepaid { get; set; }

    public string Ccdmcuenta { get; set; } = null!;

    public byte? Moneid { get; set; }

    public decimal CcdmpagoTotal { get; set; }

    public decimal CcdmredondeoTotal { get; set; }

    public int Ccdmcantidad { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public virtual TcajaTurnoConciliacion Conc { get; set; } = null!;

    public virtual TmetodoPago Mepa { get; set; } = null!;

    public virtual TsunattipoMonedum? Mone { get; set; }
}
