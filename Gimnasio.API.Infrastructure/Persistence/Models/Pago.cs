using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class Pago
{
    public long PagoId { get; set; }

    public long VentaId { get; set; }

    public int MetodoPagoId { get; set; }

    public long? CorteCajaId { get; set; }

    public int UsuarioId { get; set; }

    public DateTime FechaPago { get; set; }

    public decimal Importe { get; set; }

    public string? Referencia { get; set; }

    public string Estado { get; set; } = null!;

    public string? Observaciones { get; set; }

    public virtual CorteCaja? CorteCaja { get; set; }

    public virtual MetodoPago MetodoPago { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;

    public virtual Ventum Venta { get; set; } = null!;
}
