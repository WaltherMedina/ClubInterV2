using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TcajaConciliacionDetalle
{
    public long Ccdeid { get; set; }

    public int Concid { get; set; }

    public byte Moneid { get; set; }

    public long Copaid { get; set; }

    public decimal CcdetotalDetalle { get; set; }

    public decimal CcdetotalCabecera { get; set; }

    public decimal CcdetotalRedondeo { get; set; }

    public decimal CcdetotalPago { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public virtual TcajaTurnoConciliacion Conc { get; set; } = null!;

    public virtual TcomprobantePagoCabecera Copa { get; set; } = null!;

    public virtual TsunattipoMonedum Mone { get; set; } = null!;
}
