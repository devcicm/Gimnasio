using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class RutinaSocio
{
    public long RutinaSocioId { get; set; }

    public int GimnasioId { get; set; }

    public int RutinaId { get; set; }

    public int SocioId { get; set; }

    public int? InstructorId { get; set; }

    public DateOnly FechaAsignacion { get; set; }

    public DateOnly FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public string Estado { get; set; } = null!;

    public string? Observaciones { get; set; }

    public virtual CatGimnasio Gimnasio { get; set; } = null!;

    public virtual Instructor? Instructor { get; set; }

    public virtual Rutina Rutina { get; set; } = null!;

    public virtual ICollection<SeguimientoEjercicio> SeguimientoEjercicios { get; set; } = new List<SeguimientoEjercicio>();

    public virtual Socio Socio { get; set; } = null!;
}
