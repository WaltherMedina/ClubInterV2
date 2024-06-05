using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TsocioEstadoAdministrativo
{
    public byte Soeaid { get; set; }

    public string Soeadescripcion { get; set; } = null!;

    public string Soeaabreviatura { get; set; } = null!;

    public virtual ICollection<TsocioGrupoFamiliar> TsocioGrupoFamiliars { get; set; } = new List<TsocioGrupoFamiliar>();
}
