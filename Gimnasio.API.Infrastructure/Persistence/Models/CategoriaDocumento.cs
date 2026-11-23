using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class CategoriaDocumento
{
    public int CategoriaDocumentoId { get; set; }

    public int GimnasioId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public bool Activo { get; set; }

    public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();

    public virtual CatGimnasio Gimnasio { get; set; } = null!;
}
