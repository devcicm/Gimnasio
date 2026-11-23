using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class HistorialObjetivoFisico
{
    public long HistorialObjetivoFisicoId { get; set; }

    public int GimnasioId { get; set; }

    public long ObjetivoFisicoId { get; set; }

    public decimal ValorRegistrado { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string? Observaciones { get; set; }

    public virtual CatGimnasio Gimnasio { get; set; } = null!;

    public virtual ObjetivoFisico ObjetivoFisico { get; set; } = null!;
}
