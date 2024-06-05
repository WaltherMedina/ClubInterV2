using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TpermisoTipo
{
    public byte Tiprid { get; set; }

    public string Tiprdescripcion { get; set; } = null!;

    public virtual ICollection<Tpermiso> Tpermisos { get; set; } = new List<Tpermiso>();
}
