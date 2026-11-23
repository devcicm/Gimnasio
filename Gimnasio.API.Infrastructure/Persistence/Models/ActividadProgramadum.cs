using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class ActividadProgramadum
{
    public long ActividadProgramadaId { get; set; }

    public int GimnasioId { get; set; }

    public int ActividadId { get; set; }

    public int SucursalId { get; set; }

    public int UsuarioResponsableId { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime? FechaFin { get; set; }

    public int? CapacidadMaxima { get; set; }

    public string Estado { get; set; } = null!;

    public string? Observaciones { get; set; }

    public virtual Actividad Actividad { get; set; } = null!;

    public virtual ICollection<ReservacionActividad> ReservacionActividads { get; set; } = new List<ReservacionActividad>();

    public virtual Sucursal Sucursal { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
