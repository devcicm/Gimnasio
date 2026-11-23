using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class AreaClase
{
    public int AreaClaseId { get; set; }

    public int GimnasioId { get; set; }

    public int SucursalId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int Capacidad { get; set; }

    public bool Activo { get; set; }

    public virtual ICollection<HorarioClase> HorarioClases { get; set; } = new List<HorarioClase>();

    public virtual Sucursal Sucursal { get; set; } = null!;
}
