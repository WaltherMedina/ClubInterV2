using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TsunattipoNotaCredito
{
    public byte Tnceid { get; set; }

    public string Tncedescripcion { get; set; } = null!;

    public bool Tncevisible { get; set; }
}
