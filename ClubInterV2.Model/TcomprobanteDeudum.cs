using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TcomprobanteDeudum
{
    public long Codeid { get; set; }

    public byte Ticoid { get; set; }

    public string Codeserie { get; set; } = null!;

    public int Codenumero { get; set; }

    public int Entiid { get; set; }

    public int Servid { get; set; }

    public bool Codedebe { get; set; }

    public bool Codeanulado { get; set; }

    public short Codecantidad { get; set; }

    public string Codecuenta { get; set; } = null!;

    public string CodecentroCosto { get; set; } = null!;

    public string Codeglosa { get; set; } = null!;

    public DateOnly Codeperiodo { get; set; }

    public DateOnly Codevencimiento { get; set; }

    public decimal Codeprecio { get; set; }

    public byte Moneid { get; set; }

    public decimal Codedescuento { get; set; }

    public decimal Codeigv { get; set; }

    public long CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public long UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public virtual Tentidad Enti { get; set; } = null!;

    public virtual Tservicio Serv { get; set; } = null!;

    public virtual ICollection<TcomprobantePagoDetalle> TcomprobantePagoDetalles { get; set; } = new List<TcomprobantePagoDetalle>();

    public virtual TsunattipoComprobante Tico { get; set; } = null!;
}
