using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TtablaMini
{
    public short Tablid { get; set; }

    public string Tabltipo { get; set; } = null!;

    public byte Tablcodigo { get; set; }

    public string Tablnombre { get; set; } = null!;
}
