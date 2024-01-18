using API_CINE.Contexto;
using API_CINE.Modelos;
using API_CINE.Modelos.DTO;
using API_CINE.Services.InterfaceService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_CINE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaController : ControllerBase
    {
        ISalaService _salaService;
        public SalaController(ISalaService salaService)
        {
            _salaService = salaService;
        }
        // GET: api/<ReservaController>
        [HttpGet]
        public async Task<ActionResult<List<SalaDTO>>> Get()
        {
            return await _salaService.ListaSalas();
        }
        /*
        // GET api/<SalaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sala>> Get(int id)
        {
            return await _context.Salas.FirstOrDefaultAsync(x => x.Id == id);
        }
        // POST api/<SalaController>
        [HttpPost]
        public async Task<ActionResult> Post(Sala sala)
        {
            if (sala != null)
            {
                _context.Salas.Add(sala);
                await _context.SaveChangesAsync();
                return Ok();
            }
            else { return BadRequest("Debe ingresar datos validos"); }
        }

        // PUT api/<SalaController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Sala sala)
        {
            Sala salaModificar = await _context.Salas.FirstOrDefaultAsync(x => x.Id == id);
            if (salaModificar != null)
            {

                salaModificar.Codigo = sala.Codigo;
                salaModificar.CantidadAsientos = sala.CantidadAsientos;
                salaModificar.Estado = sala.Estado;
                await _context.SaveChangesAsync();
                return Ok();
            }
            else { return NotFound(); }
        }

        // DELETE api/<SalaController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            Sala salasEliminar = await _context.Salas.FirstOrDefaultAsync(x => x.Id == id);
            if (salasEliminar != null)
            {
                _context.Remove(salasEliminar);

                await _context.SaveChangesAsync();
                return Ok();
            }
            else { return NotFound(); }
        }
        */
    }
}
