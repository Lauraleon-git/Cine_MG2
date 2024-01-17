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
    [Required(ErrorMessage = "el campo es requerido")]
    public string Nombre { get; set; } = null!;

    [StringLength(50)]
    [Required(ErrorMessage = "el campo es requerido")]
    public string Apellido { get; set; } = null!;
    [Required(ErrorMessage = "el campo es requerido")]
    public int Telefono { get; set; }
   

    [Column("CI")]
    [Required(ErrorMessage = "el campo es requerido")]
    public int Ci { get; set; }

    [StringLength(50)]
    [Required(ErrorMessage = "el campo es requerido")]
    public string Direccion { get; set; } = null!;

    [InverseProperty("Persona")]
    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();

    [InverseProperty("Personas")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
