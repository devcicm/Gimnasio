using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class Ejercicio
{
    public int EjercicioId { get; set; }

    public int GrupoMuscularId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Instrucciones { get; set; }

    public string TipoEjercicio { get; set; } = null!;

    public string? EquipoNecesario { get; set; }

    public string? ImagenUrl { get; set; }

    public string? VideoUrl { get; set; }

    public bool Activo { get; set; }

    public virtual ICollection<EjercicioRutina> EjercicioRutinas { get; set; } = new List<EjercicioRutina>();

    public virtual GrupoMuscular GrupoMuscular { get; set; } = null!;
}
