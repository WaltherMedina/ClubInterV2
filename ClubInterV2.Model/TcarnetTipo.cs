using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TcarnetTipo
{
    public byte Ticaid { get; set; }

    public string Ticadescripcion { get; set; } = null!;

    public bool Ticaestado { get; set; }

    public virtual ICollection<TpersonaCarnet> TpersonaCarnets { get; set; } = new List<TpersonaCarnet>();
}
