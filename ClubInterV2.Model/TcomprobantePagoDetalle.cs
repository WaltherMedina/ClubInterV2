using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TcomprobantePagoDetalle
{
    public long Copdid { get; set; }

    public long Copaid { get; set; }

    public short Copditem { get; set; }

    public long Codeid { get; set; }

    public short Copdcantidad { get; set; }

    public string Copdcuenta { get; set; } = null!;

    public string CopdcentroCosto { get; set; } = null!;

    public string Copdglosa { get; set; } = null!;

    public DateOnly Copdvencimiento { get; set; }

    public decimal Copdprecio { get; set; }

    public byte Moneid { get; set; }

    public decimal Copddescuento { get; set; }

    public decimal Copdigv { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public virtual TcomprobanteDeudum Code { get; set; } = null!;

    public virtual TcomprobantePagoCabecera Copa { get; set; } = null!;

    public virtual TsunattipoMonedum Mone { get; set; } = null!;
}
