using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_CINE.Modelos;

[Table("Cartelera")]
public partial class Cartelera
{
    [Key]
    public int Id { get; set; }

    public int Precio { get; set; }

    [Column("Cantidad_boletos")]
    public int CantidadBoletos { get; set; }

    public DateTime Horario { get; set; }

    [Column("PromocionID")]
    public int PromocionId { get; set; }

    public int PeliculaId { get; set; }

    public int SalaId { get; set; }

    public string? Estado { get; set; }

    [ForeignKey("PeliculaId")]
    [InverseProperty("Carteleras")]
    public virtual Pelicula Pelicula { get; set; } = null!;

    [ForeignKey("PromocionId")]
    [InverseProperty("Carteleras")]
    public virtual Promocion Promocion { get; set; } = null!;

    [InverseProperty("Cartelera")]
    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();

    [ForeignKey("SalaId")]
    [InverseProperty("Carteleras")]
    public virtual Sala Sala { get; set; } = null!;
}
