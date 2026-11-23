using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class Servicio
{
    public int ServicioId { get; set; }

    public int CategoriaServicioId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Precio { get; set; }

    public int? DuracionMinutos { get; set; }

    public bool RequiereReservacion { get; set; }

    public bool Activo { get; set; }

    public virtual CategoriaServicio CategoriaServicio { get; set; } = null!;

    public virtual ICollection<ContratacionServicio> ContratacionServicios { get; set; } = new List<ContratacionServicio>();

    public virtual ICollection<ServicioSucursal> ServicioSucursals { get; set; } = new List<ServicioSucursal>();
}
