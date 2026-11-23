using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class ReservacionActividad
{
    public long ReservacionActividadId { get; set; }

    public int GimnasioId { get; set; }

    public long ActividadProgramadaId { get; set; }

    public int SocioId { get; set; }

    public DateTime FechaReservacion { get; set; }

    public string Estado { get; set; } = null!;

    public string? Observaciones { get; set; }

    public virtual ActividadProgramadum ActividadProgramadum { get; set; } = null!;

    public virtual AsistenciaActividad? AsistenciaActividad { get; set; }

    public virtual Socio Socio { get; set; } = null!;
}
