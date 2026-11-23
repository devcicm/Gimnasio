using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class Clase
{
    public int ClaseId { get; set; }

    public int TipoClaseId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int DuracionMinutos { get; set; }

    public bool Activo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public virtual ICollection<HorarioClase> HorarioClases { get; set; } = new List<HorarioClase>();

    public virtual TipoClase TipoClase { get; set; } = null!;
}
