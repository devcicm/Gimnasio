using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class DiaRutina
{
    public int DiaRutinaId { get; set; }

    public int GimnasioId { get; set; }

    public int RutinaId { get; set; }

    public int DiaSemanaId { get; set; }

    public string? Nombre { get; set; }

    public int Orden { get; set; }

    public bool Descanso { get; set; }

    public virtual DiaSemana DiaSemana { get; set; } = null!;

    public virtual ICollection<EjercicioRutina> EjercicioRutinas { get; set; } = new List<EjercicioRutina>();

    public virtual CatGimnasio Gimnasio { get; set; } = null!;

    public virtual Rutina Rutina { get; set; } = null!;
}
