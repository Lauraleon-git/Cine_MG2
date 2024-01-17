using API_CINE.Contexto;
using API_CINE.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_CINE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly CineContext _context;
        public ReservaController(CineContext context)
        {
            _context = context;
        }
        // GET: api/<ReservaController>
        [HttpGet]
        public async Task<ActionResult<List<Reserva>>> Get()
        {
            return await _context.Reservas.ToListAsync();
        }
        // GET api/<ReservaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Reserva>> Get(int id)
        {
            return await _context.Reservas.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpGet("reporte3")]
        public async Task<ActionResult<List<reporte3>>> ListaReservaPersona()
        {
            var consulta = await _context.Reservas.Select(x => new reporte3
            {
                IdReserva = x.Id,
                Cantidad = x.Cantidad,
                Nombre = x.Persona.Nombre,
                Apellido = x.Persona.Apellido,
                Ci = x.Persona.Ci,
            }).ToListAsync();
            return Ok(consulta);
        }


        // POST api/<ReservaController>
        [HttpPost]
        public async Task<ActionResult> Post(Reserva reserva)
        {
            if (reserva != null)
            {
                _context.Reservas.Add(reserva);
                await _context.SaveChangesAsync();
                return Ok();
            }
            else { return BadRequest("Debe ingresar datos validos"); }
        }

        // PUT api/<ReservaController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Reserva reserva)
        {
            Reserva reservaModificar = await _context.Reservas.FirstOrDefaultAsync(x => x.Id == id);
            if (reservaModificar != null)
            {

                reservaModificar.Cantidad = reserva.Cantidad;
                reservaModificar.FechaReserva = reserva.FechaReserva;
                reservaModificar.Estado = reserva.Estado;
                await _context.SaveChangesAsync();
                return Ok();
            }
            else { return NotFound(); }
        }

        // DELETE api/<ReservaController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id, Reserva reserva)
        {
            Reserva reservaEliminar = await _context.Reservas.FirstOrDefaultAsync(x => x.Id == id);
            if (reservaEliminar != null)
            {
                _context.Remove(reservaEliminar);

                await _context.SaveChangesAsync();
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        
    }
    public class reporte3
    {
        public int? IdReserva { get; set; }
        public int? Cantidad { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int? Ci { get; set; }
    }
}
