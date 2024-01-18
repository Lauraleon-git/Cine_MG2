using API_CINE.Modelos.DTO;

namespace API_CINE.Services.InterfaceService
{
    public interface IReservaService
    {
        public Task<bool> InsertUsuario(ReservaDTO reserva);
        public Task<bool> UpdateUsuario(ReservaDTO reserva, int id);
        public Task<bool> DeleteUsuario(int id);
        public Task<List<ReservaDTO>> ListaReservas();
    }
}
