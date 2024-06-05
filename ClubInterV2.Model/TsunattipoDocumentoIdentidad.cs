using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TsunattipoDocumentoIdentidad
{
    public byte Stdiid { get; set; }

    public string Stdidescripcion { get; set; } = null!;

    public string Stdicodigo { get; set; } = null!;

    public bool Stdivisible { get; set; }

    public string Stdiabreviatura { get; set; } = null!;
}
