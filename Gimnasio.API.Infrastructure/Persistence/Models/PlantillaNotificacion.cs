using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class PlantillaNotificacion
{
    public int PlantillaNotificacionId { get; set; }

    public int GimnasioId { get; set; }

    public int TipoNotificacionId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Asunto { get; set; }

    public string Contenido { get; set; } = null!;

    public string Canal { get; set; } = null!;

    public bool Activo { get; set; }

    public virtual CatGimnasio Gimnasio { get; set; } = null!;

    public virtual ICollection<Notificacion> Notificacions { get; set; } = new List<Notificacion>();

    public virtual TipoNotificacion TipoNotificacion { get; set; } = null!;
}
