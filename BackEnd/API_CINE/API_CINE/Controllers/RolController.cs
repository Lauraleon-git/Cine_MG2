using API_CINE.Contexto;
using API_CINE.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_CINE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly CineContext _context;
        public RolController(CineContext context)
        {
            _context= context;
        }
        // GET: api/<RolController>
        [HttpGet]
        public async Task<ActionResult<List<Rol>>> Get()
        {
            return await _context.Rols.ToListAsync();
        }

        // GET api/<RolController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rol>> Get(int id)
        {
            return await _context.Rols.FirstOrDefaultAsync(x => x.Id == id);
        }

        // POST api/<RolController>
        [HttpPost]
        public async Task<ActionResult>Post(Rol rol)
        {
            if (rol != null)
            {
                _context.Rols.Add(rol);
                await _context.SaveChangesAsync();
                return Ok();

            }
            else
            {
                return BadRequest("Debe ingresar datos Validos ");
            }
        }
        

        

        // PUT api/<RolController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Rol rol)
        {
            Rol rolModificar=await _context.Rols.FirstOrDefaultAsync(rol => rol.Id == id);
            if(rolModificar != null)
            {
                rolModificar.Nombre= rol.Nombre;
                rolModificar.Descripcion= rol.Descripcion;
                rolModificar.Estado=rol.Estado;
                await _context.SaveChangesAsync();
                return Ok();

            }
            else
            {
                return NotFound();
            }
        }

        // DELETE api/<RolController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id , Rol rol)

        {
            Rol rolEliminar = await _context.Rols.FirstOrDefaultAsync(r => r.Id == id);
            if (rolEliminar != null)
            {
                _context.Remove(rolEliminar);
                await _context.SaveChangesAsync();
                return Ok();

            }
            else { return NotFound(); }
        }
    }
}
