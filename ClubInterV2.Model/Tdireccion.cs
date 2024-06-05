using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class Tdireccion
{
    public int Direid { get; set; }

    public short Ubigid { get; set; }

    public byte Ditiid { get; set; }

    public string Direnombre { get; set; } = null!;

    public bool DiresinNumero { get; set; }

    public string Direcuadra { get; set; } = null!;

    public string Direnumero { get; set; } = null!;

    public string Direedificio { get; set; } = null!;

    public string Diredepartamento { get; set; } = null!;

    public string Direinterior { get; set; } = null!;

    public string Direreferencia { get; set; } = null!;

    public string Direobservaciones { get; set; } = null!;

    public bool Direestado { get; set; }

    public string DiretelefonoFijo { get; set; } = null!;

    public string CreatedDate { get; set; } = null!;

    public DateTime CreatedBy { get; set; }

    public string UpdatedDate { get; set; } = null!;

    public DateTime UpdatedBy { get; set; }

    public virtual TdireccionTipo Diti { get; set; } = null!;

    public virtual ICollection<Tempresa> Tempresas { get; set; } = new List<Tempresa>();

    public virtual ICollection<TentidadDireccion> TentidadDireccions { get; set; } = new List<TentidadDireccion>();

    public virtual Tubigeo Ubig { get; set; } = null!;
}
