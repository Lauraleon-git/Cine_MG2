using API_CINE.Contexto;
using API_CINE.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_CINE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarteleraController : ControllerBase
    {
        private readonly CineContext _context;
        public CarteleraController(CineContext context)
        {
            _context = context;
        }

        // GET: api/<CarteleraController>
        [HttpGet]
        public async Task<ActionResult<List<Cartelera>>> Get()
        {
            return await _context.Carteleras.ToListAsync();
        }

        // GET api/<CarteleraController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cartelera>> Get(int id)
        {
            return await _context.Carteleras.FirstOrDefaultAsync(x => x.Id == id);
        }

        // POST api/<CarteleraController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CarteleraController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CarteleraController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
