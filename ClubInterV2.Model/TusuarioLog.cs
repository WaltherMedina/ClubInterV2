using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TusuarioLog
{
    public int Loguid { get; set; }

    public int Userid { get; set; }

    public DateTime LoguultimoIntento { get; set; }

    public bool LoguinicioExitoso { get; set; }

    public bool LogusesionVigente { get; set; }

    public virtual Tusuario User { get; set; } = null!;
}
