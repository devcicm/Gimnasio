using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class CompraProveedor
{
    public long CompraProveedorId { get; set; }

    public int SucursalId { get; set; }

    public int ProveedorId { get; set; }

    public int UsuarioId { get; set; }

    public string Folio { get; set; } = null!;

    public DateTime FechaCompra { get; set; }

    public decimal Subtotal { get; set; }

    public decimal Descuento { get; set; }

    public decimal Impuesto { get; set; }

    public decimal Total { get; set; }

    public string Estado { get; set; } = null!;

    public string? Observaciones { get; set; }

    public virtual ICollection<DetalleCompraProveedor> DetalleCompraProveedors { get; set; } = new List<DetalleCompraProveedor>();

    public virtual ICollection<MovimientoInventario> MovimientoInventarios { get; set; } = new List<MovimientoInventario>();

    public virtual Proveedor Proveedor { get; set; } = null!;

    public virtual Sucursal Sucursal { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
