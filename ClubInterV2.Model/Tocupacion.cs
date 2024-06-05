using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class Tocupacion
{
    public short Ocupid { get; set; }

    public string Ocupdescripcion { get; set; } = null!;

    public string Ocupabreviatura { get; set; } = null!;

    public virtual ICollection<TpersonaTrabajo> TpersonaTrabajos { get; set; } = new List<TpersonaTrabajo>();
}
