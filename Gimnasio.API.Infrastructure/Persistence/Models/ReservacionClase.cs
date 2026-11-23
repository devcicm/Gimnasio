using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class ReservacionClase
{
    public long ReservacionClaseId { get; set; }

    public int GimnasioId { get; set; }

    public long SesionClaseId { get; set; }

    public int SocioId { get; set; }

    public DateTime FechaReservacion { get; set; }

    public string Estado { get; set; } = null!;

    public DateTime? FechaCancelacion { get; set; }

    public DateTime? FechaAsistencia { get; set; }

    public string? Observaciones { get; set; }

    public virtual AsistenciaClase? AsistenciaClase { get; set; }

    public virtual SesionClase SesionClase { get; set; } = null!;

    public virtual Socio Socio { get; set; } = null!;
}
