using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class MembresiaSocio
{
    public int MembresiaSocioId { get; set; }

    public int GimnasioId { get; set; }

    public int SocioId { get; set; }

    public int PlanMembresiaId { get; set; }

    public int SucursalCompraId { get; set; }

    public int? MembresiaAnteriorId { get; set; }

    public string TipoOperacion { get; set; } = null!;

    public DateTime FechaContratacion { get; set; }

    public DateOnly FechaInicio { get; set; }

    public DateOnly FechaFin { get; set; }

    public decimal PrecioContratado { get; set; }

    public decimal CuotaInscripcion { get; set; }

    public decimal Descuento { get; set; }

    public string Estado { get; set; } = null!;

    public string? Observaciones { get; set; }

    public DateTime FechaCreacion { get; set; }

    public byte[] Version { get; set; } = null!;

    public virtual ICollection<AccesoSocio> AccesoSocios { get; set; } = new List<AccesoSocio>();

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();

    public virtual CatGimnasio Gimnasio { get; set; } = null!;

    public virtual ICollection<HistorialMembresium> HistorialMembresia { get; set; } = new List<HistorialMembresium>();

    public virtual ICollection<MembresiaSocio> InverseMembresiaSocioNavigation { get; set; } = new List<MembresiaSocio>();

    public virtual MembresiaSocio? MembresiaSocioNavigation { get; set; }

    public virtual ICollection<MembresiaSucursal> MembresiaSucursals { get; set; } = new List<MembresiaSucursal>();

    public virtual PlanMembresium PlanMembresium { get; set; } = null!;

    public virtual Socio Socio { get; set; } = null!;

    public virtual Sucursal Sucursal { get; set; } = null!;

    public virtual ICollection<VisitaSocio> VisitaSocios { get; set; } = new List<VisitaSocio>();
}
