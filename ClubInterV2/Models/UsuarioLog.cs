﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubInterV2.Models
{
    public class UsuarioLog
    {
        public int LogUId { get; set; }
        public DateTime LogUltimoIntento { get; set; }
        public bool LogUInicioExitoso { get; set; }
        public bool LogUSesionVigente { get; set; }
        public int UserId { get; set; }
        public Usuario User { get; set; }
    }
}
