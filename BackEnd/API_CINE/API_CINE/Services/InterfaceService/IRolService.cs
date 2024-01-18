using API_CINE.Modelos.DTO;

namespace API_CINE.Services.InterfacesService
{
    public interface IRolService
    {
        public Task<bool> InsertarRol();
        public Task<bool> UpdateRol();
        public Task<bool> DeleteRol();
        public Task<List<RolDTO>> ListarRol();
    }
}
