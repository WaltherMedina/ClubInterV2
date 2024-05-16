using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClubInterV2.Data;
using ClubInterV2.Models;


namespace ClubInterV2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context; // Inyecta el contexto de la base de datos

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // Verificar si las credenciales son válidas
            var usuario = _context.TUsuario.SingleOrDefault(u => u.UserUsuario == request.Usuario && u.UserContrasena == request.Contrasena);

            if (usuario == null)
            {
                // Devolver Unauthorized si las credenciales son incorrectas
                return Unauthorized();
            }

            // Si las credenciales son válidas, devolver el Id del usuario
            return Ok(usuario.UserId);
        }

        // GET: api/Usuario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            return await _context.TUsuario.ToListAsync();
        }
    }
}
