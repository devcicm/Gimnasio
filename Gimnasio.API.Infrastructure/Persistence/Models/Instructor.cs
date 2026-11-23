using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class Instructor
{
    public int InstructorId { get; set; }

    public int? UsuarioId { get; set; }

    public string Nombre { get; set; } = null!;

    public string ApellidoPaterno { get; set; } = null!;

    public string? ApellidoMaterno { get; set; }

    public string? Correo { get; set; }

    public string? Telefono { get; set; }

    public string? Especialidad { get; set; }

    public string? Biografia { get; set; }

    public DateOnly? FechaContratacion { get; set; }

    public bool Activo { get; set; }

    public DateTime FechaRegistro { get; set; }

    public virtual ICollection<EvaluacionFisica> EvaluacionFisicas { get; set; } = new List<EvaluacionFisica>();

    public virtual ICollection<HorarioClase> HorarioClases { get; set; } = new List<HorarioClase>();

    public virtual ICollection<RutinaSocio> RutinaSocios { get; set; } = new List<RutinaSocio>();

    public virtual Usuario? Usuario { get; set; }
}
