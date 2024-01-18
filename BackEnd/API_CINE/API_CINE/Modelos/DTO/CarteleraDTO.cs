using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_CINE.Modelos.DTO
{
    public class CarteleraDTO
    {
   
    
        public int Precio { get; set; }
        public int CantidadBoletos { get; set; }
      
        public DateTime Horario { get; set; }

        public string? Estado { get; set; }

    }
}
