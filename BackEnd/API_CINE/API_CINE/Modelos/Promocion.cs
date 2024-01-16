using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_CINE.Modelos;

[Table("Promocion")]
public partial class Promocion
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(200)]
    public string Descripcion { get; set; } = null!;

    public string? Estado { get; set; }

    [InverseProperty("Promocion")]
    public virtual ICollection<Cartelera> Carteleras { get; set; } = new List<Cartelera>();
}
