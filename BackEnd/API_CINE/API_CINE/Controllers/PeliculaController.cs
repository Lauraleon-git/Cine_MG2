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

        [HttpGet("reporte2")]
        public async Task<ActionResult<List<reporte2>>> ListapeliculasCartelera()
        {
            var consulta = await _context.Carteleras.Select(x => new reporte2
            {
                Idcartelera = x.Id,
                Precio = x.Precio,
                CantidadBoletos = x.CantidadBoletos,
                Titulo = x.Pelicula.Titulo,
                Anio = x.Pelicula.Año,
            }).ToListAsync();
            return Ok(consulta);
        }
        

        // POST api/<PeliculaController>
        [HttpPost]
        public async Task<ActionResult> Post(Pelicula pelicula)
        {
            if (pelicula != null)
            {
                _context.Peliculas.Add(pelicula);
                await _context.SaveChangesAsync();
                return Ok();
            }
            else { return BadRequest("Debe ingresar datos validos"); }
        }

        // PUT api/<PeliculaController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Pelicula pelicula)
        {
            Pelicula peliculaModificar = await _context.Peliculas.FirstOrDefaultAsync(x => x.Id == id);
            if (peliculaModificar != null)
            {
                peliculaModificar.Titulo = pelicula.Titulo;
                peliculaModificar.Sinopsis = pelicula.Sinopsis;
                peliculaModificar.Director = pelicula.Director;
                peliculaModificar.Pais = pelicula.Pais;
                peliculaModificar.Año = pelicula.Año;
                peliculaModificar.Duracion = pelicula.Duracion;
                peliculaModificar.Genero = pelicula.Genero;
                peliculaModificar.Productora = pelicula.Productora;
                peliculaModificar.Idioma = pelicula.Idioma;
                peliculaModificar.Clasificacion = pelicula.Clasificacion;
                peliculaModificar.PortadaPelicula = pelicula.PortadaPelicula;
                peliculaModificar.Trailer = pelicula.Trailer;
                peliculaModificar.Estado = pelicula.Estado;

                await _context.SaveChangesAsync();
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE api/<PeliculaController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id, Pelicula pelicula)
        {
            Pelicula peliculaEliminar = await _context.Peliculas.FirstOrDefaultAsync(x => x.Id == id);
            if (peliculaEliminar != null)
            {
                _context.Remove(peliculaEliminar);

                await _context.SaveChangesAsync();
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
        
    }

    public class reporte2
    {
        public int? Idcartelera { get; set; }
        public int? Precio { get; set; }
        public int? CantidadBoletos { get; set; }
        public string? Titulo { get; set; }
        public int? Anio { get; set; }
    }
}
