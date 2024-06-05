using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TsunatunidadMedidum
{
    public byte Suumid { get; set; }

    public string Suumdescripcion { get; set; } = null!;

    public string Suumcodigo { get; set; } = null!;

    public bool Suumvisible { get; set; }

    public virtual ICollection<Tservicio> Tservicios { get; set; } = new List<Tservicio>();
}
