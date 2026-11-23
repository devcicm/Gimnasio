using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class VisitaSocio
{
    public long VisitaSocioId { get; set; }

    public int SocioId { get; set; }

    public int SucursalId { get; set; }

    public int? MembresiaSocioId { get; set; }

    public int? AreaGimnasioId { get; set; }

    public DateTime FechaEntrada { get; set; }

    public DateTime? FechaSalida { get; set; }

    public string TipoRegistro { get; set; } = null!;

    public string? Observaciones { get; set; }

    public virtual AreaGimnasio? AreaGimnasio { get; set; }

    public virtual MembresiaSocio? MembresiaSocio { get; set; }

    public virtual Socio Socio { get; set; } = null!;

    public virtual Sucursal Sucursal { get; set; } = null!;
}
