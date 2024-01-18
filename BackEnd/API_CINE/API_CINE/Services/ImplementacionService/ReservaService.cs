using API_CINE.Contexto;
using API_CINE.Modelos.DTO;
using API_CINE.Services.InterfaceService;
using Microsoft.EntityFrameworkCore;

namespace API_CINE.Services.ImplementacionService
{
    public class ReservaService : IReservaService
    {
        CineContext cinebdContext;

        public ReservaService(CineContext _cinebdContext)
        {
            cinebdContext = _cinebdContext;
        }
        public Task<bool> DeleteUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertUsuario(ReservaDTO reserva)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ReservaDTO>> ListaReservas()
        {
            var resultado = await cinebdContext.Reservas.Select(x => new ReservaDTO
            {
               Cantidad = x.Cantidad,
               FechaReserva = x.FechaReserva,
               Estado = x.Estado
            }).ToListAsync();
            return resultado;
        }

        public Task<bool> UpdateUsuario(ReservaDTO reserva, int id)
        {
            throw new NotImplementedException();
        }
    }
}
