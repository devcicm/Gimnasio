using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class SaldoSocio
{
    public long SaldoSocioId { get; set; }

    public int SocioId { get; set; }

    public long? VentaId { get; set; }

    public string TipoMovimiento { get; set; } = null!;

    public decimal Importe { get; set; }

    public string Concepto { get; set; } = null!;

    public DateTime FechaMovimiento { get; set; }

    public int UsuarioId { get; set; }

    public virtual Socio Socio { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;

    public virtual Ventum? Venta { get; set; }
}
