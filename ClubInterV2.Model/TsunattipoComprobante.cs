using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TsunattipoComprobante
{
    public byte Ticoid { get; set; }

    public string Ticonombre { get; set; } = null!;

    public bool Ticovisible { get; set; }

    public virtual ICollection<TcomprobanteDeudum> TcomprobanteDeuda { get; set; } = new List<TcomprobanteDeudum>();

    public virtual ICollection<TcomprobantePagoCabecera> TcomprobantePagoCabeceras { get; set; } = new List<TcomprobantePagoCabecera>();

    public virtual ICollection<TcomprobanteSerie> TcomprobanteSeries { get; set; } = new List<TcomprobanteSerie>();
}
