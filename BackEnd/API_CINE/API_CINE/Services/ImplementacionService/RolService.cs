using API_CINE.Contexto;
using API_CINE.Modelos.DTO;
using API_CINE.Services.InterfacesService;

namespace API_CINE.Services.ImplementacionServices
{
    public class RolService : IRolService
    {
        CineContext cineContext;
        public RolService(CineContext _cineContext)
        {
            cineContext = _cineContext; 
        }
        public Task<bool> DeleteRol()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertarRol()
        {
            throw new NotImplementedException();
        }

        public async Task<List<RolDTO>> ListarRol()
        {
            var resultado = cineContext.Rols.Select(x => new RolDTO
                {
                Nombre = x.Nombre,
                Descripcion = x.Descripcion,
                Estado = x.Estado,
            }).ToList();
            return resultado;
        }

        public Task<bool> UpdateRol()
        {
            throw new NotImplementedException();
        }
    }
}
