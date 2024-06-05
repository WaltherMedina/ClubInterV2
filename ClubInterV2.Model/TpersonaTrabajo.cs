using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TpersonaTrabajo
{
    public int Persid { get; set; }

    public int PersidentidadTrabajo { get; set; }

    public bool Petrvigente { get; set; }

    public short Ocupid { get; set; }

    public string PetrcelularOficina { get; set; } = null!;

    public string PetranexoOficina { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public virtual Tocupacion Ocup { get; set; } = null!;

    public virtual Tpersona Pers { get; set; } = null!;

    public virtual Tpersona PersidentidadTrabajoNavigation { get; set; } = null!;
}
