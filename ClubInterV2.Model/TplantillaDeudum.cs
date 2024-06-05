using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TplantillaDeudum
{
    public long Plaid { get; set; }

    public int? Persid { get; set; }

    public int Plafrecuencia { get; set; }

    public DateTime PlafechaInicio { get; set; }

    public DateTime PlafechaFin { get; set; }

    public bool Plaestado { get; set; }

    public long CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public long UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public int Servid { get; set; }

    public virtual Tpersona? Pers { get; set; }

    public virtual Tservicio Serv { get; set; } = null!;
}
