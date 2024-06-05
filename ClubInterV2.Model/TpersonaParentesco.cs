using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TpersonaParentesco
{
    public int Persid { get; set; }

    public int Persidpadre { get; set; }

    public int Persidmadre { get; set; }

    public bool ParevalidezLegalPadre { get; set; }

    public bool ParevalidezLegalMadre { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public virtual Tpersona Pers { get; set; } = null!;

    public virtual Tpersona PersidmadreNavigation { get; set; } = null!;

    public virtual Tpersona PersidpadreNavigation { get; set; } = null!;
}
