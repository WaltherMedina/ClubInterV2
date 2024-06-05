using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TcajaPermiso
{
    public int Capeid { get; set; }

    public byte Cajaid { get; set; }

    public int Userid { get; set; }

    public DateOnly CapefechaInicio { get; set; }

    public DateOnly CapefechaFin { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public virtual ICollection<TcajaPermisoSerie> TcajaPermisoSeries { get; set; } = new List<TcajaPermisoSerie>();

    public virtual ICollection<TcajaPermisoTurno> TcajaPermisoTurnos { get; set; } = new List<TcajaPermisoTurno>();
}
