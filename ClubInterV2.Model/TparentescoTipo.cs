using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TparentescoTipo
{
    public byte Tiprid { get; set; }

    public string Tiprdescripcion { get; set; } = null!;

    public string Tiprabreviatura { get; set; } = null!;

    public bool Tiprmembresia { get; set; }

    public virtual ICollection<TsocioGrupoFamiliar> TsocioGrupoFamiliars { get; set; } = new List<TsocioGrupoFamiliar>();
}
