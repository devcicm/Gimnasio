using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class EjercicioRutina
{
    public int EjercicioRutinaId { get; set; }

    public int DiaRutinaId { get; set; }

    public int EjercicioId { get; set; }

    public int Orden { get; set; }

    public int Series { get; set; }

    public string? Repeticiones { get; set; }

    public decimal? Peso { get; set; }

    public int? TiempoSegundos { get; set; }

    public int? DescansoSegundos { get; set; }

    public string? Observaciones { get; set; }

    public virtual DiaRutina DiaRutina { get; set; } = null!;

    public virtual Ejercicio Ejercicio { get; set; } = null!;

    public virtual ICollection<SeguimientoEjercicio> SeguimientoEjercicios { get; set; } = new List<SeguimientoEjercicio>();
}
