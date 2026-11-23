using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class IncidenciaOperativa
{
    public long IncidenciaOperativaId { get; set; }

    public int GimnasioId { get; set; }

    public int SucursalId { get; set; }

    public int? UsuarioId { get; set; }

    public int? AreaGimnasioId { get; set; }

    public string Titulo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string Prioridad { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public DateTime FechaReporte { get; set; }

    public DateTime? FechaResolucion { get; set; }

    public string? ObservacionesResolucion { get; set; }

    public virtual AreaGimnasio? AreaGimnasio { get; set; }

    public virtual CatGimnasio Gimnasio { get; set; } = null!;

    public virtual Sucursal Sucursal { get; set; } = null!;

    public virtual Usuario? Usuario { get; set; }
}
