using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class ContratacionServicio
{
    public long ContratacionServicioId { get; set; }

    public int GimnasioId { get; set; }

    public int ServicioId { get; set; }

    public int SocioId { get; set; }

    public int SucursalId { get; set; }

    public long? VentaId { get; set; }

    public int UsuarioRegistroId { get; set; }

    public DateTime FechaContratacion { get; set; }

    public DateOnly? FechaInicio { get; set; }

    public DateOnly? FechaFin { get; set; }

    public decimal PrecioAplicado { get; set; }

    public string Estado { get; set; } = null!;

    public string? Observaciones { get; set; }

    public virtual ICollection<ReservacionServicio> ReservacionServicios { get; set; } = new List<ReservacionServicio>();

    public virtual Servicio Servicio { get; set; } = null!;

    public virtual Socio Socio { get; set; } = null!;

    public virtual Sucursal Sucursal { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;

    public virtual Ventum? Ventum { get; set; }
}
