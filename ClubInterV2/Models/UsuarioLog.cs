using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubInterV2.Models
{
    [Table ("TUsuarioLog")]
    public class UsuarioLog
    {
        [Key]
        public int LogUId { get; set; }
        public int UserId { get; set; }
        public DateTime LogUltimoIntento { get; set; }
        public bool LogUInicioExitoso { get; set; }
        public bool LogUSesionVigente { get; set; }
    }
}
