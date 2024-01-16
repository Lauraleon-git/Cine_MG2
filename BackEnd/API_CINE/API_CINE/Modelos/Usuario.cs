using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_CINE.Modelos;

[Table("Usuario")]
public partial class Usuario
{
    [Key]
    public int Id { get; set; }

    [Column("Usuario")]
    [StringLength(50)]
    public string Usuario1 { get; set; } = null!;

    [StringLength(50)]
    public string Contraseña { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Estado { get; set; } = null!;

    public int PersonasId { get; set; }

    public int RolesId { get; set; }

    [ForeignKey("PersonasId")]
    [InverseProperty("Usuarios")]
    public virtual Persona Personas { get; set; } = null!;

    [ForeignKey("RolesId")]
    [InverseProperty("Usuarios")]
    public virtual Rol Roles { get; set; } = null!;
}
