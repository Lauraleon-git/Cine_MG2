using API_CINE.Modelos.DTO;

namespace API_CINE.Services.InterfaceService
{
    public interface IPeliculaService
    {
        public Task<bool> InsertPelicula(PeliculaDTO pelicula);
        public Task<bool> UpdatePelicula(PeliculaDTO pelicula, int id);
        public Task<bool> DeletePelicula(int id);
        public Task<List<PeliculaDTO>> ListaPeliculas();
    }
}
