using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class ExcepcionHorarioSucursal
{
    public int ExcepcionHorarioSucursalId { get; set; }

    public int SucursalId { get; set; }

    public DateOnly Fecha { get; set; }

    public bool Cerrado { get; set; }

    public TimeOnly? HoraApertura { get; set; }

    public TimeOnly? HoraCierre { get; set; }

    public string? Motivo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public virtual Sucursal Sucursal { get; set; } = null!;
}
