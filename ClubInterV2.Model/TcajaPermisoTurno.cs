using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TcajaPermisoTurno
{
    public int Captid { get; set; }

    public int Capeid { get; set; }

    public short Ptcjid { get; set; }

    public bool Captestado { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public virtual TcajaPermiso Cape { get; set; } = null!;

    public virtual TplantillaTurnoCaja Ptcj { get; set; } = null!;
}
