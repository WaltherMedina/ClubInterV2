using ClubInterV2.Data;
using ClubInterV2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClubInterV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprobantesDeudaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ComprobantesDeudaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<ComprobanteDeuda>> CreateComprobanteDeuda(ComprobanteDeuda comprobanteDeuda)
        {
            _context.TComprobanteDeuda.Add(comprobanteDeuda);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetComprobanteDeuda), new { id = comprobanteDeuda.ComprobanteDeudaId }, comprobanteDeuda);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ComprobanteDeuda>> GetComprobanteDeuda(int id)
        {
            var comprobanteDeuda = await _context.TComprobanteDeuda.FindAsync(id);
            if (comprobanteDeuda == null)
            {
                return NotFound();
            }
            return comprobanteDeuda;
        }
    }

}
