using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class Tpermiso
{
    public int Permid { get; set; }

    public string Permnombre { get; set; } = null!;

    public string Permdescripcion { get; set; } = null!;

    public bool Permestado { get; set; }

    public byte Tiprid { get; set; }

    public string CreatedDate { get; set; } = null!;

    public int CreatedBy { get; set; }

    public string UpdatedDate { get; set; } = null!;

    public int UpdatedBy { get; set; }

    public virtual TpermisoTipo Tipr { get; set; } = null!;
}
