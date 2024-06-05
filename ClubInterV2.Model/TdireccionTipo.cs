using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TdireccionTipo
{
    public byte Ditiid { get; set; }

    public string Ditidescripcion { get; set; } = null!;

    public string Ditiabreviatura { get; set; } = null!;

    public virtual ICollection<Tdireccion> Tdireccions { get; set; } = new List<Tdireccion>();
}
