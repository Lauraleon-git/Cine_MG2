using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_CINE.Modelos.DTO
{
    public class ReservaDTO
    {
        public int Cantidad { get; set; }
        public DateTime FechaReserva { get; set; }
        public string Estado { get; set; } = null!;
    }
}
