using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class DetalleVentum
{
    public long DetalleVentaId { get; set; }

    public int GimnasioId { get; set; }

    public long VentaId { get; set; }

    public int CategoriaVentaId { get; set; }

    public int? MembresiaSocioId { get; set; }

    public int? PlanMembresiaId { get; set; }

    public string Descripcion { get; set; } = null!;

    public decimal Cantidad { get; set; }

    public decimal PrecioUnitario { get; set; }

    public decimal Descuento { get; set; }

    public decimal Impuesto { get; set; }

    public decimal Importe { get; set; }

    public virtual CategoriaVentum CategoriaVenta { get; set; } = null!;

    public virtual MembresiaSocio? MembresiaSocio { get; set; }

    public virtual PlanMembresium? PlanMembresium { get; set; }

    public virtual Ventum Ventum { get; set; } = null!;
}
