using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TentidadDireccion
{
    public int Endiid { get; set; }

    public int Entiid { get; set; }

    public int Direid { get; set; }

    public bool Endivigente { get; set; }

    public bool EndiprincipalLocal { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public virtual Tdireccion Dire { get; set; } = null!;

    public virtual Tentidad Enti { get; set; } = null!;
}
