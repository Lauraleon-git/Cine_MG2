using API_CINE.Contexto;
using API_CINE.Modelos.DTO;
using API_CINE.Services.InterfaceService;
using Microsoft.EntityFrameworkCore;

namespace API_CINE.Services.ImplementacionService
{
    public class PromocionService : IPromocionService
    {
        CineContext cinebdContext;

        public PromocionService(CineContext _cinebdContext)
        {
            cinebdContext = _cinebdContext;
        }
        public Task<bool> DeletePromocion(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertPromocion(PromocionDTO promocion)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PromocionDTO>> ListaPromociones()
        {
            var resultado = await cinebdContext.Promocions.Select(x => new PromocionDTO
            {
                Nombre = x.Nombre,
                Descripcion = x.Descripcion,
                Estado = x.Estado,
            }).ToListAsync();
            return resultado;
        }

        public Task<bool> UpdatePromocion(PromocionDTO promocion, int id)
        {
            throw new NotImplementedException();
        }
    }
}
