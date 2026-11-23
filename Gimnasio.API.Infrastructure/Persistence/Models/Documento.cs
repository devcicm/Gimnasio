using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class Documento
{
    public long DocumentoId { get; set; }

    public int GimnasioId { get; set; }

    public int CategoriaDocumentoId { get; set; }

    public int? SocioId { get; set; }

    public int? UsuarioId { get; set; }

    public int? SucursalId { get; set; }

    public int UsuarioCargaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string NombreArchivo { get; set; } = null!;

    public string Extension { get; set; } = null!;

    public string RutaArchivo { get; set; } = null!;

    public string? TipoMime { get; set; }

    public long? TamanoBytes { get; set; }

    public DateTime FechaCarga { get; set; }

    public DateOnly? FechaVencimiento { get; set; }

    public string Estado { get; set; } = null!;

    public string? Observaciones { get; set; }

    public virtual CategoriaDocumento CategoriaDocumento { get; set; } = null!;

    public virtual CatGimnasio Gimnasio { get; set; } = null!;

    public virtual Socio? Socio { get; set; }

    public virtual Sucursal? Sucursal { get; set; }

    public virtual Usuario Usuario { get; set; } = null!;

    public virtual Usuario? UsuarioNavigation { get; set; }
}
