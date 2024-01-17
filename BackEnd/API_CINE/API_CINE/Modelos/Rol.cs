using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_CINE.Modelos;

[Table("Rol")]
public partial class Rol
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Required(ErrorMessage = "el campo es requerido")]
    public string Nombre { get; set; } = null!;

    [StringLength(200)]
    [Required(ErrorMessage = "el campo es requerido")]
    public string Descripcion { get; set; } = null!;
    

    public string Estado { get; set; } = null!;

    [InverseProperty("Roles")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
