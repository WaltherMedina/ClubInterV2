using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TsunattipoAfectacion
{
    public byte Sutaid { get; set; }

    public string Sutadescripcion { get; set; } = null!;

    public bool Sutavisible { get; set; }

    public virtual ICollection<Tservicio> Tservicios { get; set; } = new List<Tservicio>();
}
