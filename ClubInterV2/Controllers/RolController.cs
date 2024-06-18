using ClubInterV2.API.Utilidad;
using ClubInterV2.BLL.Servicios.Contrato;
using ClubInterV2.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClubInterV2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly IRolService _rolServicio;

        public RolController(IRolService rolServicio)
        {
            _rolServicio = rolServicio;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        [Route("Lista")]
        public async Task<IActionResult> Lista()
        {
            var rsp = new Response<List<RolDTO>>();
            try
            {
                rsp.status = true;
                rsp.value = await _rolServicio.Lista();
            }
            catch(Exception ex) {
                rsp.status = false;
                rsp.msg = ex.Message;
            }
            return Ok(rsp);
        }
    }
}
