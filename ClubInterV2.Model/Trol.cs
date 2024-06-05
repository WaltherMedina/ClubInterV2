using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class Trol
{
    public byte Roleid { get; set; }

    public string Roledescripcion { get; set; } = null!;

    public bool Roleestado { get; set; }

    public DateTime CreatedDate { get; set; }

    public byte CreatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public byte UpdatedBy { get; set; }

    public virtual ICollection<Tusuario> Tusuarios { get; set; } = new List<Tusuario>();
}
