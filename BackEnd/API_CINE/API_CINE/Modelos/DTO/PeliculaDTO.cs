using System.ComponentModel.DataAnnotations;

namespace API_CINE.Modelos.DTO
{
    public class PeliculaDTO
    {
        public string Titulo { get; set; } = null!;
        public string Sinopsis { get; set; } = null!;
        public string Director { get; set; } = null!;
        public string Pais { get; set; } = null!;
        public int Año { get; set; }
        public string Duracion { get; set; } = null!;
        public string Genero { get; set; } = null!;
        public string Productora { get; set; } = null!;
        public string Idioma { get; set; } = null!;
        public string Clasificacion { get; set; } = null!;
        public string? PortadaPelicula { get; set; }
        public string Trailer { get; set; } = null!;
        public string? Estado { get; set; }
    }
}
