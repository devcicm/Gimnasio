using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class PoliticaGimnasio
{
    public int PoliticaGimnasioId { get; set; }

    public string Clave { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string Valor { get; set; } = null!;

    public bool Activo { get; set; }

    public DateTime FechaActualizacion { get; set; }
}
