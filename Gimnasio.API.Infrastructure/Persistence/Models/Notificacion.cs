using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class Notificacion
{
    public long NotificacionId { get; set; }

    public int GimnasioId { get; set; }

    public int TipoNotificacionId { get; set; }

    public int? PlantillaNotificacionId { get; set; }

    public int? SocioId { get; set; }

    public int? UsuarioId { get; set; }

    public int? SucursalId { get; set; }

    public string Titulo { get; set; } = null!;

    public string Mensaje { get; set; } = null!;

    public string Canal { get; set; } = null!;

    public DateTime? FechaProgramada { get; set; }

    public DateTime? FechaEnvio { get; set; }

    public string Estado { get; set; } = null!;

    public string? ErrorEnvio { get; set; }

    public virtual CatGimnasio Gimnasio { get; set; } = null!;

    public virtual ICollection<HistorialNotificacion> HistorialNotificacions { get; set; } = new List<HistorialNotificacion>();

    public virtual ICollection<NotificacionLectura> NotificacionLecturas { get; set; } = new List<NotificacionLectura>();

    public virtual PlantillaNotificacion? PlantillaNotificacion { get; set; }

    public virtual Socio? Socio { get; set; }

    public virtual Sucursal? Sucursal { get; set; }

    public virtual TipoNotificacion TipoNotificacion { get; set; } = null!;

    public virtual Usuario? Usuario { get; set; }
}
