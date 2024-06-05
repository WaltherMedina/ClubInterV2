using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class Tservicio
{
    public int Servid { get; set; }

    public byte Svstid { get; set; }

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

    public bool Servrestringido { get; set; }

    public byte Suumid { get; set; }

    public byte ServcantidadPaquete { get; set; }

    public bool Servdinamico { get; set; }

    public string Servmensaje { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public virtual TsunattipoAfectacion Suta { get; set; } = null!;

    public virtual TsunatunidadMedidum Suum { get; set; } = null!;

    public virtual TservicioTipo Svst { get; set; } = null!;

    public virtual ICollection<TcomprobanteDeudum> TcomprobanteDeuda { get; set; } = new List<TcomprobanteDeudum>();

    public virtual ICollection<ThistoricoServicio> ThistoricoServicios { get; set; } = new List<ThistoricoServicio>();

    public virtual ICollection<TplantillaDeudum> TplantillaDeuda { get; set; } = new List<TplantillaDeudum>();
}
