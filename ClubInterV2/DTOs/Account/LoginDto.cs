using System.ComponentModel.DataAnnotations;

namespace ClubInterV2.DTOs.Account
{
    public class LoginDto
    {
        [Required]
        public string Usuario { get; set; }
        [Required] 
        public string Password { get; set; }

    }
}
