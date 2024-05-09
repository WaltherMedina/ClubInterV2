namespace ClubInterV2.Models
{
    public class Usuario
    {
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
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }
    }
}