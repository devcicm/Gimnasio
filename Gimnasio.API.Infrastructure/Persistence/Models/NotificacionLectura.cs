using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class NotificacionLectura
{
    public long NotificacionLecturaId { get; set; }

    public int GimnasioId { get; set; }

    public long NotificacionId { get; set; }

    public int? UsuarioId { get; set; }

    public int? SocioId { get; set; }

    public DateTime FechaLectura { get; set; }

    public virtual Notificacion Notificacion { get; set; } = null!;

    public virtual Socio? Socio { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
