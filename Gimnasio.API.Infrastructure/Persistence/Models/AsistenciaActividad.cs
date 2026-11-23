using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class AsistenciaActividad
{
    public long AsistenciaActividadId { get; set; }

    public int GimnasioId { get; set; }

    public long ReservacionActividadId { get; set; }

    public int UsuarioRegistroId { get; set; }

    public DateTime FechaRegistro { get; set; }

    public bool Asistio { get; set; }

    public virtual ReservacionActividad ReservacionActividad { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
