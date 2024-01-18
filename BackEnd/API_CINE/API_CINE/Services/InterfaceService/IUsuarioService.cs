using API_CINE.Modelos.DTO;

namespace API_CINE.Services.InterfaceService
{
    public interface IUsuarioService
    {
        public Task<bool> InsertUsuario(UsuarioDTO usuario);
        public Task<bool> UpdateUsuario(UsuarioDTO usuario, int id);
        public Task<bool> DeleteUsuario(int id);
        public Task<List<UsuarioDTO>> ListaUsuarios();
    }
}
