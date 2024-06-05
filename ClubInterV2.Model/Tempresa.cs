using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class Tempresa
{
    public int Emprid { get; set; }

    public int Entiid { get; set; }

    public byte Paisid { get; set; }

    public string Emprruc { get; set; } = null!;

    public string EmprrazonSocial { get; set; } = null!;

    public string EmprnombreComercial { get; set; } = null!;

    public string EmprtelefonoFijoCentral { get; set; } = null!;

    public int Direid { get; set; }

    public bool Emprsunatactivo { get; set; }

    public virtual Tdireccion Dire { get; set; } = null!;

    public virtual Tentidad Enti { get; set; } = null!;

    public virtual Tpai Pais { get; set; } = null!;
}
