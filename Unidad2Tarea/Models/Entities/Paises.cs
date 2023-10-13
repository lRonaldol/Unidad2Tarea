using System;
using System.Collections.Generic;

namespace Unidad2Tarea.Models.Entities;

public partial class Paises
{
    internal readonly int IdPais;

    public int Id { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Razas> Razas { get; set; } = new List<Razas>();
}
