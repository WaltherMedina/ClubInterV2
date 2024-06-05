using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TcomprobanteSerie
{
    public byte Seriid { get; set; }

    public byte Ticoid { get; set; }

    public string Seriserie { get; set; } = null!;

    public string Serinombre { get; set; } = null!;

    public bool Seriestado { get; set; }

    public virtual ICollection<TcajaPermisoSerie> TcajaPermisoSeries { get; set; } = new List<TcajaPermisoSerie>();

    public virtual ICollection<TcajaSerie> TcajaSeries { get; set; } = new List<TcajaSerie>();

    public virtual TsunattipoComprobante Tico { get; set; } = null!;
}
