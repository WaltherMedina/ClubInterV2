using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubInterV2.DTO
{
    public class UsuarioDTO
    {
        public int Userid { get; set; }
        public string Userusuario { get; set; } = null!;
        public string Usercontrasena { get; set; } = null!;
        public bool Userestado { get; set; }
        public string Usercorreo { get; set; } = null!;
        public byte Roleid { get; set; }
        public string? RoleDescription { get; set; }
    }
}
