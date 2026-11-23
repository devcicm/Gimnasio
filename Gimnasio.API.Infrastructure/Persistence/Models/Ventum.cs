using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class Ventum
{
    public long VentaId { get; set; }

    public int SucursalId { get; set; }

    public int? CajaId { get; set; }

    public long? CorteCajaId { get; set; }

    public int? SocioId { get; set; }

    public int UsuarioId { get; set; }

    public string Folio { get; set; } = null!;

    public DateTime FechaVenta { get; set; }

    public decimal Subtotal { get; set; }

    public decimal Descuento { get; set; }

    public decimal Impuesto { get; set; }

    public decimal Total { get; set; }

    public string Estado { get; set; } = null!;

    public string? Observaciones { get; set; }

    public virtual Caja? Caja { get; set; }

    public virtual ICollection<ContratacionServicio> ContratacionServicios { get; set; } = new List<ContratacionServicio>();

    public virtual CorteCaja? CorteCaja { get; set; }

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();

    public virtual ICollection<MovimientoInventario> MovimientoInventarios { get; set; } = new List<MovimientoInventario>();

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    public virtual ICollection<SaldoSocio> SaldoSocios { get; set; } = new List<SaldoSocio>();

    public virtual Socio? Socio { get; set; }

    public virtual Sucursal Sucursal { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
