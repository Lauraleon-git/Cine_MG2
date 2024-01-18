using API_CINE.Modelos.DTO;

namespace API_CINE.Services.InterfaceService
{
    public interface ISalaService
    {
        public Task<bool> InsertUsuario(SalaDTO sala);
        public Task<bool> UpdateUsuario(SalaDTO sala, int id);
        public Task<bool> DeleteUsuario(int id);
        public Task<List<SalaDTO>> ListaSalas();
    }
}
