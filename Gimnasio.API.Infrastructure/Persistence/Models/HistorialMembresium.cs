using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class HistorialMembresium
{
    public long HistorialMembresiaId { get; set; }

    public int GimnasioId { get; set; }

    public int MembresiaSocioId { get; set; }

    public int? UsuarioId { get; set; }

    public string TipoEvento { get; set; } = null!;

    public string? EstadoAnterior { get; set; }

    public string? EstadoNuevo { get; set; }

    public string? Descripcion { get; set; }

    public DateTime FechaEvento { get; set; }

    public virtual MembresiaSocio MembresiaSocio { get; set; } = null!;

    public virtual Usuario? Usuario { get; set; }
}
