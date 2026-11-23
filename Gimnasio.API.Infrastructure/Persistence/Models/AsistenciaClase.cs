using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class AsistenciaClase
{
    public long AsistenciaClaseId { get; set; }

    public int GimnasioId { get; set; }

    public long ReservacionClaseId { get; set; }

    public int? UsuarioRegistroId { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string? Observaciones { get; set; }

    public virtual ReservacionClase ReservacionClase { get; set; } = null!;

    public virtual Usuario? Usuario { get; set; }
}
