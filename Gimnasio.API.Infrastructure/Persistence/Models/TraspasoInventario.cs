using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class TraspasoInventario
{
    public long TraspasoInventarioId { get; set; }

    public int SucursalOrigenId { get; set; }

    public int SucursalDestinoId { get; set; }

    public int UsuarioId { get; set; }

    public string Folio { get; set; } = null!;

    public DateTime FechaSolicitud { get; set; }

    public DateTime? FechaRecepcion { get; set; }

    public string Estado { get; set; } = null!;

    public string? Observaciones { get; set; }

    public virtual ICollection<DetalleTraspasoInventario> DetalleTraspasoInventarios { get; set; } = new List<DetalleTraspasoInventario>();

    public virtual Sucursal SucursalDestino { get; set; } = null!;

    public virtual Sucursal SucursalOrigen { get; set; } = null!;

    public virtual Usuario Usuario { get; set; } = null!;
}
