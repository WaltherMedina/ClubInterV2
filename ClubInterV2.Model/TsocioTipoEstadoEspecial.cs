using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TsocioTipoEstadoEspecial
{
    public byte Steeid { get; set; }

    public string Steedescripcion { get; set; } = null!;

    public virtual ICollection<Tsocio> Tsocios { get; set; } = new List<Tsocio>();
}
