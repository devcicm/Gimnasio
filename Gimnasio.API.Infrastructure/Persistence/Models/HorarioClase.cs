using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class HorarioClase
{
    public long HorarioClaseId { get; set; }

    public int GimnasioId { get; set; }

    public int SucursalId { get; set; }

    public int ClaseId { get; set; }

    public int InstructorId { get; set; }

    public int? AreaClaseId { get; set; }

    public int DiaSemanaId { get; set; }

    public TimeOnly HoraInicio { get; set; }

    public TimeOnly HoraFin { get; set; }

    public DateOnly FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public int Capacidad { get; set; }

    public bool Activo { get; set; }

    public virtual AreaClase? AreaClase { get; set; }

    public virtual Clase Clase { get; set; } = null!;

    public virtual DiaSemana DiaSemana { get; set; } = null!;

    public virtual Instructor Instructor { get; set; } = null!;

    public virtual ICollection<SesionClase> SesionClases { get; set; } = new List<SesionClase>();

    public virtual Sucursal Sucursal { get; set; } = null!;
}
