using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class HorarioSucursal
{
    public int HorarioSucursalId { get; set; }

    public int GimnasioId { get; set; }

    public int SucursalId { get; set; }

    public int DiaSemanaId { get; set; }

    public TimeOnly HoraApertura { get; set; }

    public TimeOnly HoraCierre { get; set; }

    public bool Cerrado { get; set; }

    public virtual DiaSemana DiaSemana { get; set; } = null!;

    public virtual CatGimnasio Gimnasio { get; set; } = null!;

    public virtual Sucursal Sucursal { get; set; } = null!;
}
