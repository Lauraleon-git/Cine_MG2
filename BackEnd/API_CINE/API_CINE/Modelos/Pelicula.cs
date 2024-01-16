using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace API_CINE.Modelos;

[Table("Pelicula")]
public partial class Pelicula
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Titulo { get; set; } = null!;

    [StringLength(200)]
    public string Sinopsis { get; set; } = null!;

    [StringLength(50)]
    public string Director { get; set; } = null!;

    [StringLength(25)]
    public string Pais { get; set; } = null!;

    public int Año { get; set; }

    public string Duracion { get; set; } = null!;

    [StringLength(25)]
    public string Genero { get; set; } = null!;

    [StringLength(50)]
    public string Productora { get; set; } = null!;

    [StringLength(50)]
    public string Idioma { get; set; } = null!;

    [StringLength(50)]
    public string Clasificacion { get; set; } = null!;

    public string? PortadaPelicula { get; set; }

    public string Trailer { get; set; } = null!;

    public string? Estado { get; set; }

    [InverseProperty("Pelicula")]
    public virtual ICollection<Cartelera> Carteleras { get; set; } = new List<Cartelera>();
}
