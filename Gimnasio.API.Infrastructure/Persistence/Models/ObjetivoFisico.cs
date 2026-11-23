using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class ObjetivoFisico
{
    public long ObjetivoFisicoId { get; set; }

    public int SocioId { get; set; }

    public string TipoObjetivo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal? ValorInicial { get; set; }

    public decimal? ValorObjetivo { get; set; }

    public string? UnidadMedida { get; set; }

    public DateOnly FechaInicio { get; set; }

    public DateOnly? FechaObjetivo { get; set; }

    public DateOnly? FechaCumplimiento { get; set; }

    public string Estado { get; set; } = null!;

    public virtual ICollection<HistorialObjetivoFisico> HistorialObjetivoFisicos { get; set; } = new List<HistorialObjetivoFisico>();

    public virtual Socio Socio { get; set; } = null!;
}
