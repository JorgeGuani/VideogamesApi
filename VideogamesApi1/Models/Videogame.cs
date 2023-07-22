using System;
using System.Collections.Generic;

namespace VideogamesApi1.Models;

public partial class Videogame
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Categoria { get; set; }

    public int? AnioLanzamiento { get; set; }

    public string? Clasificacion { get; set; }

    public string? Plataformas { get; set; }
}
