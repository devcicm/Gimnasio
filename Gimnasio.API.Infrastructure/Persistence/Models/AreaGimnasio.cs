using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class AreaGimnasio
{
    public int AreaGimnasioId { get; set; }

    public int GimnasioId { get; set; }

    public int SucursalId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int? Capacidad { get; set; }

    public bool Activo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public virtual CatGimnasio Gimnasio { get; set; } = null!;

    public virtual ICollection<IncidenciaOperativa> IncidenciaOperativas { get; set; } = new List<IncidenciaOperativa>();

    public virtual Sucursal Sucursal { get; set; } = null!;

    public virtual ICollection<VisitaSocio> VisitaSocios { get; set; } = new List<VisitaSocio>();
}
