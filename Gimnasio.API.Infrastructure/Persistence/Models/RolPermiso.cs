using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class RolPermiso
{
    public int RolId { get; set; }

    public int PermisoId { get; set; }

    public DateTime FechaAsignacion { get; set; }

    public virtual Permiso Permiso { get; set; } = null!;

    public virtual Rol Rol { get; set; } = null!;
}
