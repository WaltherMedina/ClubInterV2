using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TpersonaTipo
{
    public byte Tipeid { get; set; }

    public string Tipedescripcion { get; set; } = null!;

    public string Tipeabreviatura { get; set; } = null!;
}
