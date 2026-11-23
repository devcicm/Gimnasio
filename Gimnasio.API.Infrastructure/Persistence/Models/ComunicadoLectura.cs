using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class ComunicadoLectura
{
    public long ComunicadoLecturaId { get; set; }

    public int GimnasioId { get; set; }

    public long ComunicadoId { get; set; }

    public int? UsuarioId { get; set; }

    public int? SocioId { get; set; }

    public DateTime FechaLectura { get; set; }

    public virtual Comunicado Comunicado { get; set; } = null!;

    public virtual Socio? Socio { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
