using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class DiaSemana
{
    public int DiaSemanaId { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<DiaRutina> DiaRutinas { get; set; } = new List<DiaRutina>();

    public virtual ICollection<HorarioClase> HorarioClases { get; set; } = new List<HorarioClase>();

    public virtual ICollection<HorarioSucursal> HorarioSucursals { get; set; } = new List<HorarioSucursal>();
}
