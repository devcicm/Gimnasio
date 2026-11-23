using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class Comunicado
{
    public long ComunicadoId { get; set; }

    public int GimnasioId { get; set; }

    public int? SucursalId { get; set; }

    public int UsuarioCreadorId { get; set; }

    public string Titulo { get; set; } = null!;

    public string Contenido { get; set; } = null!;

    public DateTime? FechaPublicacion { get; set; }

    public DateTime? FechaExpiracion { get; set; }

    public string PublicoObjetivo { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public virtual ICollection<ComunicadoLectura> ComunicadoLecturas { get; set; } = new List<ComunicadoLectura>();

    public virtual CatGimnasio Gimnasio { get; set; } = null!;

    public virtual Sucursal? Sucursal { get; set; }

    public virtual Usuario Usuario { get; set; } = null!;
}
