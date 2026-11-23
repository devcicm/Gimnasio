using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class Actividad
{
    public int ActividadId { get; set; }

    public int GimnasioId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string TipoActividad { get; set; } = null!;

    public int? CapacidadMaxima { get; set; }

    public bool RequiereReservacion { get; set; }

    public bool Activo { get; set; }

    public virtual ICollection<ActividadProgramadum> ActividadProgramada { get; set; } = new List<ActividadProgramadum>();

    public virtual CatGimnasio Gimnasio { get; set; } = null!;
}
