using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class MovimientoCaja
{
    public long MovimientoCajaId { get; set; }

    public long CorteCajaId { get; set; }

    public int UsuarioId { get; set; }

    public string TipoMovimiento { get; set; } = null!;

    public string Concepto { get; set; } = null!;

    public decimal Importe { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public string? Observaciones { get; set; }

    public virtual CorteCaja CorteCaja { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
