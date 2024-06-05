using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TturnoCaja
{
    public int Tucaid { get; set; }

    public DateOnly Tucafecha { get; set; }

    public short Ptcjid { get; set; }

    public int Userid { get; set; }

    public DateTime Tucaapertura { get; set; }

    public DateTime Tucacierre { get; set; }

    public bool Tucacerrado { get; set; }

    public virtual TplantillaTurnoCaja Ptcj { get; set; } = null!;

    public virtual ICollection<TcajaTurnoConciliacion> TcajaTurnoConciliacions { get; set; } = new List<TcajaTurnoConciliacion>();

    public virtual Tusuario User { get; set; } = null!;
}
