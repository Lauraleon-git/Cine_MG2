using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_CINE.Modelos.Entity;

[Table("Pelicula")]
public partial class Pelicula
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Required(ErrorMessage = "el campo es requerido")]
    public string Titulo { get; set; } = null!;

    [StringLength(200)]
    [Required(ErrorMessage = "el campo es requerido")]
    public string Sinopsis { get; set; } = null!;

    [StringLength(50)]
    [Required(ErrorMessage = "el campo es requerido")]
    public string Director { get; set; } = null!;

    [StringLength(25)]
    [Required(ErrorMessage = "el campo es requerido")]
    public string Pais { get; set; } = null!;
    [Required(ErrorMessage = "el campo es requerido")]
    public int Año { get; set; }
    [Required(ErrorMessage = "el campo es requerido")]
    public string Duracion { get; set; } = null!;

    [StringLength(25)]
    [Required(ErrorMessage = "el campo es requerido")]
    public string Genero { get; set; } = null!;

    [StringLength(50)]
    [Required(ErrorMessage = "el campo es requerido")]
    public string Productora { get; set; } = null!;

    [StringLength(50)]
    [Required(ErrorMessage = "el campo es requerido")]
    public string Idioma { get; set; } = null!;

    [StringLength(50)]
    [Required(ErrorMessage = "el campo es requerido")]
    public string Clasificacion { get; set; } = null!;
    [Required(ErrorMessage = "el campo es requerido")]
    public string? PortadaPelicula { get; set; }
    [Required(ErrorMessage = "el campo es requerido")]
    public string Trailer { get; set; } = null!;

    public string? Estado { get; set; }

    [InverseProperty("Pelicula")]
    public virtual ICollection<Cartelera> Carteleras { get; set; } = new List<Cartelera>();
}
