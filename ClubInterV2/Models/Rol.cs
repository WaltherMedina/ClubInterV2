using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubInterV2.Models
{
    [Table("TRol")]
    public class Rol
    {
        [Key]
        public byte RoleId { get; set; }
        public string RoleDescripcion { get; set; }
        public bool RoleEstado { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int UpdatedBy { get; set; }

        // Propiedad de navegación inversa para la relación con Usuario
        public Usuario Usuario { get; set; }
    }

}

