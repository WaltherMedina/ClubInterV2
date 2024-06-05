using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class Tentidad
{
    public int Entiid { get; set; }

    public bool Entipersona { get; set; }

    public string Entinombre { get; set; } = null!;

    public string Entiidentidad { get; set; } = null!;

    public virtual ICollection<TcomprobanteDeudum> TcomprobanteDeuda { get; set; } = new List<TcomprobanteDeudum>();

    public virtual ICollection<TcomprobantePagoCabecera> TcomprobantePagoCabeceras { get; set; } = new List<TcomprobantePagoCabecera>();

    public virtual ICollection<Tempresa> Tempresas { get; set; } = new List<Tempresa>();

    public virtual ICollection<TentidadDireccion> TentidadDireccions { get; set; } = new List<TentidadDireccion>();

    public virtual ICollection<Tpersona> Tpersonas { get; set; } = new List<Tpersona>();
}
