using API_CINE.Contexto;
using API_CINE.Modelos;
using API_CINE.Modelos.DTO;
using API_CINE.Services.InterfaceService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_CINE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        // GET: api/<UsuarioController>
        [HttpGet]
        public async Task<ActionResult<List<UsuarioDTO>>> Get()
        {
            return await _usuarioService.ListaUsuarios();
        }

        // GET api/<UsuarioController>/5
        /*[HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> Get(int id)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        //reporte4
        [HttpGet("reporte4")]
        public async Task<ActionResult<List<reporte4>>> ListarUsuariosRol()
        {
            var consulta = await _context.Usuarios.Select(x => new reporte4
            {
                Idusuario = x.Id,
                Usuario = x.Usuario1,
                Contrasenia = x.Contraseña,
                NombreRol = x.Roles.Nombre,
                EstadoRol = x.Roles.Estado,
            }).ToListAsync();
            return Ok(consulta);
        }

        //reporte5
        [HttpGet("reporte5")]
        public async Task<ActionResult<List<reporte5>>> ListarPersonasUsuariosRol()
        {
            var consulta = await _context.Usuarios.Select(x => new reporte5
            {
                Idusuario = x.Id,
                Usuario = x.Usuario1,
                Contrasenia = x.Contraseña,
                NombreRol = x.Roles.Nombre,
                NombrePersona = x.Personas.Nombre,
                ApellidoPersona = x.Personas.Apellido,
                TelefonoPersona = x.Personas.Telefono,
                CiPersona = x.Personas.Ci,
                EstadoRol = x.Roles.Estado,

            }).ToListAsync();
            return Ok(consulta);
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public async Task<ActionResult> Post(Usuario usuario)
        {
            if (usuario != null)
            {
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();
                return Ok();
            }
            else { return BadRequest("Debe ingresar datos validos"); }
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Usuario usuario)
        {
            Usuario usuarioModificar = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
            if (usuarioModificar != null)
            {
                usuarioModificar.Usuario1 = usuario.Usuario1;
                usuarioModificar.Contraseña = usuario.Contraseña;
                usuarioModificar.Fecha = usuario.Fecha;
                usuarioModificar.Estado = usuario.Estado;

                await _context.SaveChangesAsync();
                return Ok();
            }
            else { return NotFound(); }
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            Usuario usuarioEliminar = await _context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
            if (usuarioEliminar != null)
            {
                _context.Remove(usuarioEliminar);

                await _context.SaveChangesAsync();
                return Ok();
            }
            else { return NotFound(); }
        }*/
        
    }


    public class reporte4
    {
        public int? Idusuario { get; set; }
        public string? Usuario { get; set; }
        public string? Contrasenia { get; set; }
        public string? NombreRol { get; set; }
        public string? EstadoRol { get; set; }
    }
    public class reporte5
    {
        public int? Idusuario { get; set; }
        public string? Usuario { get; set; }
        public string? Contrasenia { get; set; }
        public string? NombreRol { get; set; }
        public string? EstadoRol { get; set; }
        public string? NombrePersona { get; set; }
        public string? ApellidoPersona { get; set; }
        public int? TelefonoPersona { get; set; }
        public int? CiPersona { get; set; }
    }
}
