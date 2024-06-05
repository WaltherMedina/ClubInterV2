using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class TsocioBeneficioMatrimonio
{
    public short Bmeaid { get; set; }

    public string SociidconyugeM { get; set; } = null!;

    public string SociidconyugeF { get; set; } = null!;

    public DateOnly BmeafechaAprobacion { get; set; }

    public bool Bmeavigente { get; set; }

    public DateOnly BmeafechaTermino { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public virtual Tsocio SociidconyugeFNavigation { get; set; } = null!;

    public virtual Tsocio SociidconyugeMNavigation { get; set; } = null!;
}
