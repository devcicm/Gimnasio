using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class SesionClase
{
    public long SesionClaseId { get; set; }

    public long HorarioClaseId { get; set; }

    public DateOnly Fecha { get; set; }

    public TimeOnly HoraInicio { get; set; }

    public TimeOnly HoraFin { get; set; }

    public int Capacidad { get; set; }

    public int LugaresReservados { get; set; }

    public string Estado { get; set; } = null!;

    public string? Observaciones { get; set; }

    public DateTime FechaCreacion { get; set; }

    public virtual HorarioClase HorarioClase { get; set; } = null!;

    public virtual ICollection<ListaEsperaClase> ListaEsperaClases { get; set; } = new List<ListaEsperaClase>();

    public virtual ICollection<ReservacionClase> ReservacionClases { get; set; } = new List<ReservacionClase>();
}
