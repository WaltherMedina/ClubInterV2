using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TcajaConciliacionDetalleCuenta
{
    public int Ccdcid { get; set; }

    public int Concid { get; set; }

    public string Ccdccuenta { get; set; } = null!;

    public byte Moneid { get; set; }

    public decimal CcdcmontoTotal { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public virtual TcajaTurnoConciliacion Conc { get; set; } = null!;
}
