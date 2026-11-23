using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class ServicioSucursal
{
    public int ServicioSucursalId { get; set; }

    public int GimnasioId { get; set; }

    public int ServicioId { get; set; }

    public int SucursalId { get; set; }

    public decimal? Precio { get; set; }

    public bool Disponible { get; set; }

    public virtual Servicio Servicio { get; set; } = null!;

    public virtual Sucursal Sucursal { get; set; } = null!;
}
