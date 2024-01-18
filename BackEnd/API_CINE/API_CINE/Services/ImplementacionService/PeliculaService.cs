using API_CINE.Contexto;
using API_CINE.Modelos.DTO;
using API_CINE.Services.InterfaceService;
using Microsoft.EntityFrameworkCore;

namespace API_CINE.Services.ImplementacionService
{
    public class PeliculaService : IPeliculaService
    {
        CineContext cinebdContext;

        public PeliculaService(CineContext _cinebdContext)
        {
            cinebdContext = _cinebdContext;
        }
        public Task<bool> DeletePelicula(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertPelicula(PeliculaDTO pelicula)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PeliculaDTO>> ListaPeliculas()
        {
            var resultado = await cinebdContext.Peliculas.Select(x => new PeliculaDTO
            {
                Titulo = x.Titulo,
                Sinopsis = x.Sinopsis,
                Director = x.Director,
                Pais = x.Pais,
                Año = x.Año,
                Duracion = x.Duracion,
                Genero = x.Genero,
                Productora = x.Productora,
                Idioma = x.Idioma,
                Clasificacion = x.Clasificacion,
                PortadaPelicula = x.PortadaPelicula,
                Trailer = x.Trailer,
                Estado = x.Estado,
            }).ToListAsync();
            return resultado;
        }

        public Task<bool> UpdatePelicula(PeliculaDTO pelicula, int id)
        {
            throw new NotImplementedException();
        }
    }
}
