using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class ParametroConfiguracion
{
    public int ParametroConfiguracionId { get; set; }

    public string Clave { get; set; } = null!;

    public string? Valor { get; set; }

    public string? Descripcion { get; set; }

    public string TipoDato { get; set; } = null!;

    public bool Activo { get; set; }

    public DateTime FechaActualizacion { get; set; }
}
