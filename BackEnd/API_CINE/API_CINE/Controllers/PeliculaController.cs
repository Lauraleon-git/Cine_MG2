using API_CINE.Contexto;
using API_CINE.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_CINE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculaController : ControllerBase
    {
        private readonly CineContext _context;
        public PeliculaController(CineContext context)
        {
            _context = context;
        }
        // GET: api/<PeliculaController>
        [HttpGet]
        public async Task<ActionResult<List<Pelicula>>> Get()
        {
            return await _context.Peliculas.ToListAsync();
        }
        // GET api/<PeliculaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pelicula>> Get(int id)
        {
            return await _context.Peliculas.FirstOrDefaultAsync(x => x.Id == id);
        }

        // POST api/<PeliculaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PeliculaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PeliculaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
