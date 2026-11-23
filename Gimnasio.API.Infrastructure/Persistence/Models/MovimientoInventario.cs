using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class MovimientoInventario
{
    public long MovimientoInventarioId { get; set; }

    public int GimnasioId { get; set; }

    public int SucursalId { get; set; }

    public int ProductoId { get; set; }

    public int UsuarioId { get; set; }

    public long? CompraProveedorId { get; set; }

    public long? VentaId { get; set; }

    public string TipoMovimiento { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public decimal ExistenciaAnterior { get; set; }

    public decimal ExistenciaNueva { get; set; }

    public decimal? CostoUnitario { get; set; }

    public string? Motivo { get; set; }

    public DateTime FechaMovimiento { get; set; }

    public virtual CompraProveedor? CompraProveedor { get; set; }

    public virtual CatGimnasio Gimnasio { get; set; } = null!;

    public virtual Producto Producto { get; set; } = null!;

    public virtual Sucursal Sucursal { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;

    public virtual Ventum? Ventum { get; set; }
}
