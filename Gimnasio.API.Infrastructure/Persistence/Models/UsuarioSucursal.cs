using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class UsuarioSucursal
{
    public int UsuarioId { get; set; }

    public int SucursalId { get; set; }

    public DateTime FechaAsignacion { get; set; }

    public bool Activo { get; set; }

    public virtual Sucursal Sucursal { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
