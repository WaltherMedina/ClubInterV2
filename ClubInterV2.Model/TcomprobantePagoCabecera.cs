using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TcomprobantePagoCabecera
{
    public long Copaid { get; set; }

    public byte Ticoid { get; set; }

    public string Copaserie { get; set; } = null!;

    public int Copanumero { get; set; }

    /// <summary>
    /// 1 contado 2 credito
    /// </summary>
    public byte CopaformaPago { get; set; }

    public string CopanumeroSocio { get; set; } = null!;

    public int Entiid { get; set; }

    public string Copacuenta { get; set; } = null!;

    public decimal CopadescuentoGlobal { get; set; }

    public bool Copaanulado { get; set; }

    public byte Moneid { get; set; }

    public decimal CopamontoTotal { get; set; }

    public decimal Copaigvtotal { get; set; }

    public decimal Copadetraccion { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public virtual Tentidad Enti { get; set; } = null!;

    public virtual TsunattipoMonedum Mone { get; set; } = null!;

    public virtual ICollection<TcajaConciliacionDetalle> TcajaConciliacionDetalles { get; set; } = new List<TcajaConciliacionDetalle>();

    public virtual ICollection<TcomprobantePagoDetalle> TcomprobantePagoDetalles { get; set; } = new List<TcomprobantePagoDetalle>();

    public virtual TsunattipoComprobante Tico { get; set; } = null!;

    public virtual ICollection<Tpago> Tpagos { get; set; } = new List<Tpago>();
}
