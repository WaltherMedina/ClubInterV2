using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TsocioEstadoEstatutario
{
    public byte Soeeid { get; set; }

    public string Soeedescripcion { get; set; } = null!;

    public string Soeeabreviatura { get; set; } = null!;

    public virtual ICollection<Tsocio> Tsocios { get; set; } = new List<Tsocio>();
}
