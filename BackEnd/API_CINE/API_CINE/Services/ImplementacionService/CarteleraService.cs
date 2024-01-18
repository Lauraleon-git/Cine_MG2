using API_CINE.Contexto;
using API_CINE.Modelos.DTO;
using API_CINE.Services.InterfacesService;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;

namespace API_CINE.Services.ImplementacionServices
{
    public class CarteleraService : ICarteleraService
    {
        CineContext cineContext;
        public CarteleraService(CineContext _cineContext)
        {
            cineContext = _cineContext;
        }

        public Task<bool> DeleteCartelera()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertarCartelera()
        {
            throw new NotImplementedException();
        }

        public  Task<List<CarteleraDTO>> ListarCartelera()
        {
            var resultado = cineContext.Carteleras.Select(x => new CarteleraDTO
            {
                Precio = x.Precio,
                CantidadBoletos= x.CantidadBoletos,
                Horario= x.Horario,
                Estado= x.Estado,
            }).ToListAsync();
            return resultado;
        }

        public Task<bool> UpdateCartelera()
        {
            throw new NotImplementedException();
        }
    }
}
