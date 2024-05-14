using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubInterV2.Models
{
    [Table("TUsuario")]
    public class Usuario
    {
        [Key]
        public int UserId { get; set; }
        public string UserUsuario { get; set; }
        public string UserContrasena { get; set; }
        public bool UserEstado { get; set; }
        public bool UserCambiarContrasena { get; set; }
        public bool UserInterno { get; set; }
        public int PersId { get; set; }
        public string UserCorreo { get; set; }
        public string UserTokenConfirmacion { get; set; }
        public DateTime UserFechaEnvioToken { get; set; }
        public DateTime UserInicioSesion { get; set; }
        public bool UserBloqueoTemporal { get; set; }
        public bool UserPermanente { get; set; }
        public DateTime UserVencimiento { get; set; }
        public byte RoleId { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public byte UpdatedBy { get; set; }

        // Propiedad de navegación para la relación con Rol
        public Rol Rol { get; set; }
        public UsuarioLog UserLog { get; set; }
    }
}