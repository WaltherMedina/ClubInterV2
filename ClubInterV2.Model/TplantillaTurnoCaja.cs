using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TplantillaTurnoCaja
{
    public short Ptcjid { get; set; }

    public byte Cajaid { get; set; }

    public byte PtcjdiaSemana { get; set; }

    public string PtcjhoraInicio { get; set; } = null!;

    public string PtcjhoraFin { get; set; } = null!;

    public bool Ptcjmedianoche { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public virtual ICollection<TcajaPermisoTurno> TcajaPermisoTurnos { get; set; } = new List<TcajaPermisoTurno>();

    public virtual ICollection<TturnoCaja> TturnoCajas { get; set; } = new List<TturnoCaja>();
}
