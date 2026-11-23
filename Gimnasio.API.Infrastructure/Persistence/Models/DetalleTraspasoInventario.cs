using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class DetalleTraspasoInventario
{
    public long DetalleTraspasoInventarioId { get; set; }

    public long TraspasoInventarioId { get; set; }

    public int ProductoId { get; set; }

    public decimal Cantidad { get; set; }

    public virtual Producto Producto { get; set; } = null!;

    public virtual TraspasoInventario TraspasoInventario { get; set; } = null!;
}
