using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class ThistoricoServicio
{
    public int Hsrvid { get; set; }

    public int Servid { get; set; }

    public string Servdescripcion { get; set; } = null!;

    public string Servabreviatura { get; set; } = null!;

    public bool ServafectoIgv { get; set; }

    public string ServcuentaPasada { get; set; } = null!;

    public string ServcuentaActual { get; set; } = null!;

    public string ServcuentaFutura { get; set; } = null!;

    public string ServcentroCosto { get; set; } = null!;

    public byte Sutaid { get; set; }

    public bool Servestado { get; set; }

    public DateOnly ServfechaInicio { get; set; }

    public DateOnly ServfechaFin { get; set; }

    public bool ServvigenciaContinua { get; set; }

    public decimal ServtarifaVigente { get; set; }

    public byte Svstid { get; set; }

    public bool Servrestringido { get; set; }

    public byte ServcantidadPaquete { get; set; }

    public bool Servdinamico { get; set; }

    public string Servmensaje { get; set; } = null!;

    public byte Suumid { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public virtual Tservicio Serv { get; set; } = null!;
}
