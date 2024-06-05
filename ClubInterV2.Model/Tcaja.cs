using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class Tcaja
{
    public byte Cajaid { get; set; }

    public string Cajahost { get; set; } = null!;

    public string Cajaip { get; set; } = null!;

    public string Cajamac { get; set; } = null!;

    public bool Cajaestado { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public virtual ICollection<TcajaSerie> TcajaSeries { get; set; } = new List<TcajaSerie>();

    public virtual ICollection<TcajaTurnoConciliacion> TcajaTurnoConciliacions { get; set; } = new List<TcajaTurnoConciliacion>();
}
