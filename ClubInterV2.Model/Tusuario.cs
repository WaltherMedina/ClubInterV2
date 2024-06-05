using System;
using System.Collections.Generic;

namespace ClubInterV2.Model;

public partial class Tusuario
{
    public int Userid { get; set; }

    public string Userusuario { get; set; } = null!;

    public string Usercontrasena { get; set; } = null!;

    public bool Userestado { get; set; }

    public bool UsercambiarContrasena { get; set; }

    public bool Userinterno { get; set; }

    public int Persid { get; set; }

    public string Usercorreo { get; set; } = null!;

    public string UsertokenConfirmacion { get; set; } = null!;

    public DateTime UserfechaEnvioToken { get; set; }

    public DateTime UserinicioSesion { get; set; }

    public bool UserbloqueoTemporal { get; set; }

    public bool Userpermanente { get; set; }

    public DateTime Uservencimiento { get; set; }

    public byte Roleid { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }

    public int UpdatedBy { get; set; }

    public virtual Tpersona Pers { get; set; } = null!;

    public virtual Trol Role { get; set; } = null!;

    public virtual ICollection<TcajaTurnoConciliacion> TcajaTurnoConciliacions { get; set; } = new List<TcajaTurnoConciliacion>();

    public virtual ICollection<TturnoCaja> TturnoCajas { get; set; } = new List<TturnoCaja>();

    public virtual ICollection<TusuarioLog> TusuarioLogs { get; set; } = new List<TusuarioLog>();
}
