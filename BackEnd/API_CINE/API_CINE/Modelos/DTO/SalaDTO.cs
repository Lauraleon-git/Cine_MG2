using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_CINE.Modelos.DTO
{
    public class SalaDTO
    {
        public string Codigo { get; set; } = null!;
        public int CantidadAsientos { get; set; }
        public string? Estado { get; set; }

    }
}
