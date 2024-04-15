using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ClubInterV2.Models
{
    public class User: IdentityUser
    {
        [Required]
        public int UsuarioId { get; set; }
        [Required]
        public string Usuario { get; set; } // Nombre de usuario
        [Required]
        public string Contrasena { get; set; }
        [Required]
        public bool Estado { get; set; } // Activo/Inactivo
        [Required]
        public bool CambiarContrasena { get; set; }
        public string Correo { get; set; }
        public DateTime? InicioSesion { get; set; } // Fecha de último inicio de sesión
        public bool BloqueoTemporal { get; set; }
        public DateTime? Vencimiento { get; set; } // Fecha de vencimiento de la contrasena
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
