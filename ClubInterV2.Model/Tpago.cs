using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class Tpago
{
    public long Pagoid { get; set; }

    public long Copaid { get; set; }

    public byte Mepaid { get; set; }

    public byte Cajaid { get; set; }

    public byte Moneid { get; set; }

    public string Pagocuenta { get; set; } = null!;

    public decimal CopamontoTotal { get; set; }

    public decimal PagomontoRedondeo { get; set; }

    public decimal PagomontoRecibido { get; set; }

    public decimal PagomontoVuelto { get; set; }

    public decimal PagomontoPagado { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public virtual TcomprobantePagoCabecera Copa { get; set; } = null!;

    public virtual TmetodoPago Mepa { get; set; } = null!;

    public virtual TsunattipoMonedum Mone { get; set; } = null!;
}
