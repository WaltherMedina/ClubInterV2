namespace ClubInterV2.Models
{
    public class Rol
    {
        public byte RoleId { get; set; }
        public string RoleDescripcion { get; set; }
        public bool RoleEstado { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public byte UpdatedBy { get; set; }
    }
}
