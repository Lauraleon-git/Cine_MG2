﻿using API_CINE.Contexto;
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
        public async Task<ActionResult> Post(Cartelera cartelera)
        {
            if (cartelera != null)
            {
                _context.Carteleras.Add(cartelera);
                await _context.SaveChangesAsync();
                return Ok();

            }
            else { return BadRequest("Debe ingresar datos validos"); }
        }

        // PUT api/<CarteleraController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Cartelera cartelera)

        {
            Cartelera carteleramodificar = await _context.Carteleras.FirstOrDefaultAsync(x => x.Id == id);
            if (carteleramodificar != null)
            {
                carteleramodificar.Precio = carteleramodificar.Precio;
                carteleramodificar.CantidadBoletos = carteleramodificar.CantidadBoletos;
                carteleramodificar.Horario = cartelera.Horario;
                carteleramodificar.Estado = cartelera.Estado;
                await _context.SaveChangesAsync();
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE api/<CarteleraController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id, Cartelera cartelera)
        {
            Cartelera carteleraEliminar = await _context.Carteleras.FirstOrDefaultAsync(x => x.Id == id);
            _context.Remove(carteleraEliminar);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpGet("reporte3")]
        public async Task<ActionResult<List<reporte3>>> ListarsalaspromocionesCartelera()
        {
            var consulta = await _context.Carteleras.Select(x => new reporte3
            {
                Idcartelera = x.Id,
                Precio = x.Precio,
                Titulo = x.Pelicula.Titulo,
                sala = x.Sala.CantidadAsientos,
                Promocion = x.Promocion.Nombre
            }).ToListAsync();
            return Ok(consulta);
        }
        public class reporte3
        {
            public int? Idcartelera { get; set; }
            public int? Precio { get; set; }
            public string? Titulo { get; set; }
            public int? sala { get; set; }
            public string? Promocion { get; set; }
        }
    }
}
