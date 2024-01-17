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


        // POST api/<ReservaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ReservaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReservaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
