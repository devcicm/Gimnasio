using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class SeguimientoEjercicio
{
    public long SeguimientoEjercicioId { get; set; }

    public long RutinaSocioId { get; set; }

    public int EjercicioRutinaId { get; set; }

    public DateTime FechaRealizacion { get; set; }

    public int SeriesCompletadas { get; set; }

    public string? RepeticionesCompletadas { get; set; }

    public decimal? PesoUtilizado { get; set; }

    public int? TiempoSegundos { get; set; }

    public string? Observaciones { get; set; }

    public virtual EjercicioRutina EjercicioRutina { get; set; } = null!;

    public virtual RutinaSocio RutinaSocio { get; set; } = null!;
}
