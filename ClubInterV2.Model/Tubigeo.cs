using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class Tubigeo
{
    public short Ubigid { get; set; }

    public byte Paisid { get; set; }

    public string Ubigcodigo { get; set; } = null!;

    public string Ubigdepartamento { get; set; } = null!;

    public string Ubigprovincia { get; set; } = null!;

    public string Ubigdistrito { get; set; } = null!;

    public string UbigcapitalLegal { get; set; } = null!;

    public bool Ubigvisible { get; set; }

    public virtual Tpai Pais { get; set; } = null!;

    public virtual ICollection<Tdireccion> Tdireccions { get; set; } = new List<Tdireccion>();
}
