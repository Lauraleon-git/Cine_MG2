using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_CINE.Modelos.Entity;

[Table("Sala")]
public partial class Sala
{
    [Key]
    public int Id { get; set; }

    [StringLength(10)]
    [Required(ErrorMessage = "el campo es requerido")]
    public string Codigo { get; set; } = null!;

    [Column("Cantidad_Asientos")]
    [Required(ErrorMessage = "el campo es requerido")]
    public int CantidadAsientos { get; set; }
    
    public string? Estado { get; set; }

    [InverseProperty("Sala")]
    public virtual ICollection<Cartelera> Carteleras { get; set; } = new List<Cartelera>();
}
