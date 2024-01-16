using API_CINE.Contexto;
using API_CINE.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace API_CINE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly CineContext _context;
        public PersonasController(CineContext context)
        {
            _context = context;
        }
        // GET: api/<PersonasController>
        [HttpGet]
        public async Task<ActionResult<List<Persona>>> Get()
        {
            return await _context.Personas.ToListAsync();
        }

        // GET api/<PersonasController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Persona>> Get(int id)
        {
            return await _context.Personas.FirstOrDefaultAsync(x => x.Id == id);
        }

        // POST api/<PersonasController>
        [HttpPost]
        public async Task<ActionResult> Post(Persona marca)
        {
            if (marca != null)
            {
                _context.Personas.Add(marca);
                await _context.SaveChangesAsync();
                return Ok();
            }
            else { return BadRequest("Debe ingresar datos validos"); }
        }

        // PUT api/<PersonasController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Persona persona)
        {
            Persona personaModificar = await _context.Personas.FirstOrDefaultAsync(x => x.Id == id);
            if (personaModificar != null)
            {
                personaModificar.Nombre = persona.Nombre;
                personaModificar.Apellido = persona.Apellido;
                personaModificar.Telefono = persona.Telefono;
                personaModificar.Ci = persona.Ci;
                personaModificar.Direccion = persona.Direccion;

                await _context.SaveChangesAsync();
                return Ok();
            }
            else { return NotFound(); }
        }

        // DELETE api/<PersonasController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            Persona personaEliminar = await _context.Personas.FirstOrDefaultAsync(x => x.Id == id);
            if (personaEliminar != null)
            {
                _context.Remove(personaEliminar);

                await _context.SaveChangesAsync();
                return Ok();
            }
            else { return NotFound(); }
        }
    }
}
