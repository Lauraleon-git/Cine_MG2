using API_CINE.Contexto;
using API_CINE.Modelos.DTO;
using API_CINE.Services.InterfaceService;
using Microsoft.EntityFrameworkCore;

namespace API_CINE.Services.ImplementacionService
{
    public class UsuarioService : IUsuarioService
    {
        CineContext cinebdContext;

        public UsuarioService(CineContext _cinebdContext)
        {
            cinebdContext = _cinebdContext;
        }
        public Task<bool> DeleteUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertUsuario(UsuarioDTO usuario)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UsuarioDTO>> ListaUsuarios()
        {
            var resultado = await cinebdContext.Usuarios.Select(x => new UsuarioDTO
            {
                Usuario1 = x.Usuario1,
                Contraseña = x.Contraseña,
                Fecha = x.Fecha,
                Estado = x.Estado,
            }).ToListAsync();
            return resultado;
        }

        public Task<bool> UpdateUsuario(UsuarioDTO usuario, int id)
        {
            throw new NotImplementedException();
        }
    }
}
