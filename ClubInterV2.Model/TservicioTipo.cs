using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TservicioTipo
{
    public byte Svstid { get; set; }

    public string Svstdescripcion { get; set; } = null!;

    public virtual ICollection<Tservicio> Tservicios { get; set; } = new List<Tservicio>();
}
