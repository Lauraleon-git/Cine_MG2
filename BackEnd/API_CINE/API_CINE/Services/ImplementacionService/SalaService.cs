using API_CINE.Contexto;
using API_CINE.Modelos.DTO;
using API_CINE.Services.InterfaceService;
using Microsoft.EntityFrameworkCore;

namespace API_CINE.Services.ImplementacionService
{
    public class SalaService : ISalaService
    {
        CineContext cinebdContext;

        public SalaService(CineContext _cinebdContext)
        {
            cinebdContext = _cinebdContext;
        }
        public Task<bool> DeleteUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertUsuario(SalaDTO sala)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SalaDTO>> ListaSalas()
        {
            var resultado = await cinebdContext.Salas.Select(x => new SalaDTO
            {
                Codigo = x.Codigo,
                CantidadAsientos = x.CantidadAsientos,
                Estado = x.Estado
               
            }).ToListAsync();
            return resultado;
        }

        public Task<bool> UpdateUsuario(SalaDTO sala, int id)
        {
            throw new NotImplementedException();
        }
    }
}
