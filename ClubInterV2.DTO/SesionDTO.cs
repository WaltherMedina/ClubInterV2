using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubInterV2.DTO
{
    public class SesionDTO//Guarda la  sesion del usuario logeado
    {
        public int Userid { get; set; }
        public string Userusuario { get; set; } = null!;
        public string Usercorreo { get; set; } = null!;
        public string? RoleDescription { get; set; }
    }
}
