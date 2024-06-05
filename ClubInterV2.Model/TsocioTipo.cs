using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TsocioTipo
{
    public byte Tisoid { get; set; }

    public string Tisodescripcion { get; set; } = null!;

    public string Tisoabreviatura { get; set; } = null!;

    public virtual ICollection<Tsocio> Tsocios { get; set; } = new List<Tsocio>();
}
