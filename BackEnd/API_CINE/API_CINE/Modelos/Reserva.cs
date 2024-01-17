using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_CINE.Modelos;

[Table("Reserva")]
public partial class Reserva
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "el campo es requerido")]
    public int Cantidad { get; set; }

    [Column("Fecha_reserva")]
    [Required(ErrorMessage = "el campo es requerido")]
    public DateTime FechaReserva { get; set; }
    
    public string Estado { get; set; } = null!;

    public int PersonaId { get; set; }

    public int CarteleraId { get; set; }

    [ForeignKey("CarteleraId")]
    [InverseProperty("Reservas")]
    public virtual Cartelera Cartelera { get; set; } = null!;

    [ForeignKey("PersonaId")]
    [InverseProperty("Reservas")]
    public virtual Persona Persona { get; set; } = null!;
}
