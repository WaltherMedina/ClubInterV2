using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TcajaSerie
{
    public short Caseid { get; set; }

    public byte Cajaid { get; set; }

    public byte Seriid { get; set; }

    public bool Caseestado { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public virtual Tcaja Caja { get; set; } = null!;

    public virtual TcomprobanteSerie Seri { get; set; } = null!;
}
