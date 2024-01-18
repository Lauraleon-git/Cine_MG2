using API_CINE.Modelos.DTO;

namespace API_CINE.Services.InterfacesService
{
    public interface ICarteleraService
    {
        public Task<bool> InsertarCartelera();
        public Task<bool> UpdateCartelera();
        public Task<bool> DeleteCartelera();
        public Task<List<CarteleraDTO>> ListarCartelera();
    }
}
