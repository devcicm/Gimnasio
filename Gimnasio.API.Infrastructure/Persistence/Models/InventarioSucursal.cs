using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class InventarioSucursal
{
    public long InventarioSucursalId { get; set; }

    public int SucursalId { get; set; }

    public int ProductoId { get; set; }

    public decimal Existencia { get; set; }

    public decimal StockReservado { get; set; }

    public DateTime FechaActualizacion { get; set; }

    public byte[] Version { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;

    public virtual Sucursal Sucursal { get; set; } = null!;
}
