using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class Socio
{
    public int SocioId { get; set; }

    public int SucursalRegistroId { get; set; }

    public string Nombre { get; set; } = null!;

    public string ApellidoPaterno { get; set; } = null!;

    public string? ApellidoMaterno { get; set; }

    public DateOnly FechaNacimiento { get; set; }

    public string Sexo { get; set; } = null!;

    public string? Correo { get; set; }

    public string? Telefono { get; set; }

    public string NombreContactoEmergencia { get; set; } = null!;

    public string TelefonoEmergencia { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? CodigoPostal { get; set; }

    public string? Municipio { get; set; }

    public string? Estado { get; set; }

    public string? FotografiaUrl { get; set; }

    public string? Observaciones { get; set; }

    public DateTime FechaRegistro { get; set; }

    public bool Activo { get; set; }

    public byte[] Version { get; set; } = null!;

    public virtual ICollection<AccesoSocio> AccesoSocios { get; set; } = new List<AccesoSocio>();

    public virtual ICollection<ComunicadoLectura> ComunicadoLecturas { get; set; } = new List<ComunicadoLectura>();

    public virtual ICollection<ContratacionServicio> ContratacionServicios { get; set; } = new List<ContratacionServicio>();

    public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();

    public virtual ICollection<EvaluacionFisica> EvaluacionFisicas { get; set; } = new List<EvaluacionFisica>();

    public virtual ICollection<ListaEsperaClase> ListaEsperaClases { get; set; } = new List<ListaEsperaClase>();

    public virtual ICollection<MembresiaSocio> MembresiaSocios { get; set; } = new List<MembresiaSocio>();

    public virtual ICollection<NotificacionLectura> NotificacionLecturas { get; set; } = new List<NotificacionLectura>();

    public virtual ICollection<Notificacion> Notificacions { get; set; } = new List<Notificacion>();

    public virtual ICollection<ObjetivoFisico> ObjetivoFisicos { get; set; } = new List<ObjetivoFisico>();

    public virtual ICollection<ReservacionActividad> ReservacionActividads { get; set; } = new List<ReservacionActividad>();

    public virtual ICollection<ReservacionClase> ReservacionClases { get; set; } = new List<ReservacionClase>();

    public virtual ICollection<ReservacionServicio> ReservacionServicios { get; set; } = new List<ReservacionServicio>();

    public virtual ICollection<RutinaSocio> RutinaSocios { get; set; } = new List<RutinaSocio>();

    public virtual ICollection<SaldoSocio> SaldoSocios { get; set; } = new List<SaldoSocio>();

    public virtual Sucursal SucursalRegistro { get; set; } = null!;

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();

    public virtual ICollection<VisitaSocio> VisitaSocios { get; set; } = new List<VisitaSocio>();
}
