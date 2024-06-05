using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TpersonaSalud
{
    public int Persid { get; set; }

    public DateOnly PersfechaNacimiento { get; set; }

    public DateOnly PersfechaFallecimiento { get; set; }

    public int UbigidciudadNacimiento { get; set; }

    public int Persidemergencia1 { get; set; }

    public int Persidemergencia2 { get; set; }

    public DateOnly Saluchequeo { get; set; }

    public string Saluobservaciones { get; set; } = null!;

    public DateOnly Saluddjjcoronavirus { get; set; }

    public bool Saludiscapacidad { get; set; }

    public string Salupersonalidad { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public string? SalutipoSangre { get; set; }

    public virtual Tpersona Pers { get; set; } = null!;

    public virtual Tpersona Persidemergencia1Navigation { get; set; } = null!;

    public virtual Tpersona Persidemergencia2Navigation { get; set; } = null!;
}
