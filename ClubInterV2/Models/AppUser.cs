using Microsoft.AspNetCore.Identity;

namespace ClubInterV2.Models
{
    public class AppUser:IdentityUser
    {
        public string? FullName  { get; set; }
    }
}
