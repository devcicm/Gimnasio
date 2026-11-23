using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class ReservacionServicio
{
    public long ReservacionServicioId { get; set; }

    public long ContratacionServicioId { get; set; }

    public int SocioId { get; set; }

    public int? UsuarioResponsableId { get; set; }

    public DateTime FechaReservacion { get; set; }

    public DateTime FechaServicio { get; set; }

    public string Estado { get; set; } = null!;

    public string? Observaciones { get; set; }

    public virtual ContratacionServicio ContratacionServicio { get; set; } = null!;

    public virtual Socio Socio { get; set; } = null!;

    public virtual Usuario? UsuarioResponsable { get; set; }
}
