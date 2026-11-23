using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class HistorialNotificacion
{
    public long HistorialNotificacionId { get; set; }

    public int GimnasioId { get; set; }

    public long NotificacionId { get; set; }

    public DateTime FechaIntento { get; set; }

    public string Resultado { get; set; } = null!;

    public string? Detalle { get; set; }

    public virtual Notificacion Notificacion { get; set; } = null!;
}
