using API_CINE.Modelos.DTO;

namespace API_CINE.Services.InterfaceService
{
    public interface IPromocionService
    {
        public Task<bool> InsertPromocion(PromocionDTO promocion);
        public Task<bool> UpdatePromocion(PromocionDTO promocion, int id);
        public Task<bool> DeletePromocion(int id);
        public Task<List<PromocionDTO>> ListaPromociones();
    }
}
