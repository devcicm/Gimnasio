using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class ProductoProveedor
{
    public int GimnasioId { get; set; }

    public int ProductoId { get; set; }

    public int ProveedorId { get; set; }

    public string? CodigoProductoProveedor { get; set; }

    public decimal PrecioCompra { get; set; }

    public bool EsPrincipal { get; set; }

    public virtual CatGimnasio Gimnasio { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;

    public virtual Proveedor Proveedor { get; set; } = null!;
}
