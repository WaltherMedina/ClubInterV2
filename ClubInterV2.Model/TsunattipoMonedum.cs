using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TsunattipoMonedum
{
    public byte Moneid { get; set; }

    public string Monenombre { get; set; } = null!;

    public string Monesimbolo { get; set; } = null!;

    public short Moneisonumero { get; set; }

    public string Moneisocodigo { get; set; } = null!;

    public virtual ICollection<TcajaConciliacionDetalleMetodoPago> TcajaConciliacionDetalleMetodoPagos { get; set; } = new List<TcajaConciliacionDetalleMetodoPago>();

    public virtual ICollection<TcajaConciliacionDetalle> TcajaConciliacionDetalles { get; set; } = new List<TcajaConciliacionDetalle>();

    public virtual ICollection<TcajaTurnoConciliacion> TcajaTurnoConciliacions { get; set; } = new List<TcajaTurnoConciliacion>();

    public virtual ICollection<TcomprobantePagoCabecera> TcomprobantePagoCabeceras { get; set; } = new List<TcomprobantePagoCabecera>();

    public virtual ICollection<TcomprobantePagoDetalle> TcomprobantePagoDetalles { get; set; } = new List<TcomprobantePagoDetalle>();

    public virtual ICollection<Tpago> Tpagos { get; set; } = new List<Tpago>();
}
