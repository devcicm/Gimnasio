using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class DetalleCompraProveedor
{
    public long DetalleCompraProveedorId { get; set; }

    public int GimnasioId { get; set; }

    public long CompraProveedorId { get; set; }

    public int ProductoId { get; set; }

    public decimal Cantidad { get; set; }

    public decimal PrecioUnitario { get; set; }

    public decimal Descuento { get; set; }

    public decimal Impuesto { get; set; }

    public decimal Importe { get; set; }

    public virtual CompraProveedor CompraProveedor { get; set; } = null!;

    public virtual CatGimnasio Gimnasio { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;
}
