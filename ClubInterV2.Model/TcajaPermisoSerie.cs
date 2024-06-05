using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TcajaPermisoSerie
{
    public int Capsid { get; set; }

    public int Capeid { get; set; }

    public byte Seriid { get; set; }

    public bool Capsestado { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public virtual TcajaPermiso Cape { get; set; } = null!;

    public virtual TcomprobanteSerie Seri { get; set; } = null!;
}
