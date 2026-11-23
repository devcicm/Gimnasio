using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class AccesoSocio
{
    public long AccesoSocioId { get; set; }

    public int SocioId { get; set; }

    public int? MembresiaSocioId { get; set; }

    public int SucursalId { get; set; }

    public DateTime FechaAcceso { get; set; }

    public string TipoAcceso { get; set; } = null!;

    public string Resultado { get; set; } = null!;

    public string MetodoIdentificacion { get; set; } = null!;

    public string? Observaciones { get; set; }

    public int? UsuarioId { get; set; }

    public virtual MembresiaSocio? MembresiaSocio { get; set; }

    public virtual Socio Socio { get; set; } = null!;

    public virtual Sucursal Sucursal { get; set; } = null!;

    public virtual Usuario? Usuario { get; set; }
}
