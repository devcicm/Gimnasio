using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class PerfilGimnasio
{
    public int PerfilGimnasioId { get; set; }

    public string NombreComercial { get; set; } = null!;

    public string? RazonSocial { get; set; }

    public string? Rfc { get; set; }

    public string? Correo { get; set; }

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public string? CodigoPostal { get; set; }

    public string? Municipio { get; set; }

    public string? Estado { get; set; }

    public string Pais { get; set; } = null!;

    public string? LogotipoUrl { get; set; }

    public DateTime FechaRegistro { get; set; }

    public bool Activo { get; set; }

    public byte[] Version { get; set; } = null!;
}
