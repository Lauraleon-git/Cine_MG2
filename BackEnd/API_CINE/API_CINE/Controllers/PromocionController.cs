using API_CINE.Contexto;
using API_CINE.Modelos;
using API_CINE.Modelos.DTO;
using API_CINE.Services.ImplementacionService;
using API_CINE.Services.InterfaceService;
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
        IPromocionService _promocionService;
        public PromocionController(IPromocionService promocionService)
        {
            _promocionService = promocionService;
        }
        // GET: api/<PromocionController>
        [HttpGet]
        public async Task<ActionResult<List<PromocionDTO>>> Get()
        {
            return await _promocionService.ListaPromociones();
        }


        // GET api/<PromocionController>/5
        /*[HttpGet("{id}")]
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
        */
    }
}
