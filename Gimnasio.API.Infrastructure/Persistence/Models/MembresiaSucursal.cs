using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class MembresiaSucursal
{
    public int MembresiaSucursalId { get; set; }

    public int MembresiaSocioId { get; set; }

    public int SucursalId { get; set; }

    public DateTime FechaAsignacion { get; set; }

    public bool Activo { get; set; }

    public virtual MembresiaSocio MembresiaSocio { get; set; } = null!;

    public virtual Sucursal Sucursal { get; set; } = null!;
}
