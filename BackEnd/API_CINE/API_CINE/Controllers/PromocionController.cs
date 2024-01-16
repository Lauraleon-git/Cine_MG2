using API_CINE.Contexto;
using API_CINE.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_CINE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromocionController : ControllerBase
    {
        private readonly CineContext _context;
        public PromocionController(CineContext context)
        {
            _context = context;
        }
        // GET: api/<PromocionController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // GET api/<PromocionController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Promocion>> Get(int id)
        {
            return await _context.Promocions.FirstOrDefaultAsync(x => x.Id == id);
        }

        // POST api/<PromocionController>
        [HttpPost]
        public async Task<ActionResult> Post(Promocion promocion)
        {
            if (promocion != null)
            {
                _context.Promocions.Add(promocion);
                await _context.SaveChangesAsync();
                return Ok();
            }
            else { return BadRequest("Debe ingresar datos validos"); }
        }

        // PUT api/<PromocionController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Promocion promocion)
        {
            Promocion promocionModificar = await _context.Promocions.FirstOrDefaultAsync(x => x.Id == id);
            if (promocionModificar != null)
            {
                promocionModificar.Nombre = promocion.Nombre;
                promocionModificar.Descripcion = promocion.Descripcion;
                promocionModificar.Estado = promocion.Estado;

                await _context.SaveChangesAsync();
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE api/<PromocionController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id, Promocion promocion)
        {
            Promocion promocionEliminar = await _context.Promocions.FirstOrDefaultAsync(x => x.Id == id);
            if (promocionEliminar != null)
            {
                _context.Remove(promocionEliminar);

                await _context.SaveChangesAsync();
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
