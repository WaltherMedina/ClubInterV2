using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TcajaTurnoConciliacion
{
    public int Concid { get; set; }

    public byte Cajaid { get; set; }

    public int Tucaid { get; set; }

    public int Userid { get; set; }

    public DateTime Concapertura { get; set; }

    public byte Moneid { get; set; }

    public decimal ConcmontoInicial { get; set; }

    public decimal ConcmontoFinal { get; set; }

    public decimal Concdescuadre { get; set; }

    public bool Conccerrado { get; set; }

    public DateTime Conccierre { get; set; }

    public bool Concestado { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public virtual Tcaja Caja { get; set; } = null!;

    public virtual TsunattipoMonedum Mone { get; set; } = null!;

    public virtual ICollection<TcajaConciliacionDetalleCuenta> TcajaConciliacionDetalleCuenta { get; set; } = new List<TcajaConciliacionDetalleCuenta>();

    public virtual ICollection<TcajaConciliacionDetalleMetodoPago> TcajaConciliacionDetalleMetodoPagos { get; set; } = new List<TcajaConciliacionDetalleMetodoPago>();

    public virtual ICollection<TcajaConciliacionDetalle> TcajaConciliacionDetalles { get; set; } = new List<TcajaConciliacionDetalle>();

    public virtual TturnoCaja Tuca { get; set; } = null!;

    public virtual Tusuario User { get; set; } = null!;
}
