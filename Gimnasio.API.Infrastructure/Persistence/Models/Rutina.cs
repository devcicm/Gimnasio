using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class Rutina
{
    public int RutinaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public string? Objetivo { get; set; }

    public string Nivel { get; set; } = null!;

    public int DuracionSemanas { get; set; }

    public int UsuarioCreadorId { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Activo { get; set; }

    public virtual ICollection<DiaRutina> DiaRutinas { get; set; } = new List<DiaRutina>();

    public virtual ICollection<RutinaSocio> RutinaSocios { get; set; } = new List<RutinaSocio>();

    public virtual Usuario UsuarioCreador { get; set; } = null!;
}
