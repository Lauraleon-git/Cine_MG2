using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_CINE.Modelos;

[Table("Persona")]
public partial class Persona
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(50)]
    public string Apellido { get; set; } = null!;

    public int Telefono { get; set; }

    [Column("CI")]
    public int Ci { get; set; }

    [StringLength(50)]
    public string Direccion { get; set; } = null!;

    [InverseProperty("Persona")]
    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();

    [InverseProperty("Personas")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
