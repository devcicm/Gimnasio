using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class ListaEsperaClase
{
    public long ListaEsperaClaseId { get; set; }

    public long SesionClaseId { get; set; }

    public int SocioId { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string Estado { get; set; } = null!;

    public DateTime? FechaNotificacion { get; set; }

    public virtual SesionClase SesionClase { get; set; } = null!;

    public virtual Socio Socio { get; set; } = null!;
}
