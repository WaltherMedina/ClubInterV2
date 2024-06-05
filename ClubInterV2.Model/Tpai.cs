using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class Tpai
{
    public byte Paisid { get; set; }

    public string Paisdescripcion { get; set; } = null!;

    public string Paisalpha2 { get; set; } = null!;

    public short PaiscodigoIso { get; set; }

    public bool Paisvisible { get; set; }

    public virtual ICollection<Tempresa> Tempresas { get; set; } = new List<Tempresa>();

    public virtual ICollection<Tpersona> Tpersonas { get; set; } = new List<Tpersona>();

    public virtual ICollection<Tubigeo> Tubigeos { get; set; } = new List<Tubigeo>();
}
