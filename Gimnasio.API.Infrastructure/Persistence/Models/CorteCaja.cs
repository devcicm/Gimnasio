using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class CorteCaja
{
    public long CorteCajaId { get; set; }

    public int CajaId { get; set; }

    public int UsuarioAperturaId { get; set; }

    public int? UsuarioCierreId { get; set; }

    public DateTime FechaApertura { get; set; }

    public DateTime? FechaCierre { get; set; }

    public decimal MontoInicial { get; set; }

    public decimal? MontoEsperado { get; set; }

    public decimal? MontoReal { get; set; }

    public decimal? Diferencia { get; set; }

    public string Estado { get; set; } = null!;

    public string? Observaciones { get; set; }

    public virtual Caja Caja { get; set; } = null!;

    public virtual ICollection<MovimientoCaja> MovimientoCajas { get; set; } = new List<MovimientoCaja>();

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    public virtual Usuario UsuarioApertura { get; set; } = null!;

    public virtual Usuario? UsuarioCierre { get; set; }

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
