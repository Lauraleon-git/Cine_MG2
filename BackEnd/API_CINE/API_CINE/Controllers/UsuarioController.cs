using API_CINE.Contexto;
using API_CINE.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_CINE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly CineContext _context;
        public UsuarioController(CineContext context)
        {
            _context = context;
        }
        // GET: api/<UsuarioController>
        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> Get()
        {
            return await _context.Usuarios.ToListAsync();
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> Get(int id)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
