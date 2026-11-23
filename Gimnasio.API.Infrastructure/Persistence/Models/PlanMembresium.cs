using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class PlanMembresium
{
    public int PlanMembresiaId { get; set; }

    public int GimnasioId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int Duracion { get; set; }

    public string UnidadDuracion { get; set; } = null!;

    public decimal Precio { get; set; }

    public decimal CuotaInscripcion { get; set; }

    public bool Activo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public byte[] Version { get; set; } = null!;

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();

    public virtual CatGimnasio Gimnasio { get; set; } = null!;

    public virtual ICollection<MembresiaSocio> MembresiaSocios { get; set; } = new List<MembresiaSocio>();
}
