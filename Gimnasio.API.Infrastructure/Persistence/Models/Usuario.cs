using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public int GimnasioId { get; set; }

    public string Nombre { get; set; } = null!;

    public string ApellidoPaterno { get; set; } = null!;

    public string? ApellidoMaterno { get; set; }

    public string Correo { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? PasswordHash { get; set; }

    public string? FotografiaUrl { get; set; }

    public string TipoAutenticacion { get; set; } = null!;

    public DateTime? UltimoAcceso { get; set; }

    public bool Activo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public byte[] Version { get; set; } = null!;

    public virtual ICollection<AccesoSocio> AccesoSocios { get; set; } = new List<AccesoSocio>();

    public virtual ICollection<ActividadProgramadum> ActividadProgramada { get; set; } = new List<ActividadProgramadum>();

    public virtual ICollection<AsistenciaActividad> AsistenciaActividads { get; set; } = new List<AsistenciaActividad>();

    public virtual ICollection<AsistenciaClase> AsistenciaClases { get; set; } = new List<AsistenciaClase>();

    public virtual ICollection<CompraProveedor> CompraProveedors { get; set; } = new List<CompraProveedor>();

    public virtual ICollection<ComunicadoLectura> ComunicadoLecturas { get; set; } = new List<ComunicadoLectura>();

    public virtual ICollection<Comunicado> Comunicados { get; set; } = new List<Comunicado>();

    public virtual ICollection<ContratacionServicio> ContratacionServicios { get; set; } = new List<ContratacionServicio>();

    public virtual ICollection<CorteCaja> CorteCajaUsuarioNavigations { get; set; } = new List<CorteCaja>();

    public virtual ICollection<CorteCaja> CorteCajaUsuarios { get; set; } = new List<CorteCaja>();

    public virtual ICollection<Documento> DocumentoUsuarioNavigations { get; set; } = new List<Documento>();

    public virtual ICollection<Documento> DocumentoUsuarios { get; set; } = new List<Documento>();

    public virtual ICollection<EvaluacionFisica> EvaluacionFisicas { get; set; } = new List<EvaluacionFisica>();

    public virtual CatGimnasio Gimnasio { get; set; } = null!;

    public virtual ICollection<HistorialMembresium> HistorialMembresia { get; set; } = new List<HistorialMembresium>();

    public virtual ICollection<IncidenciaOperativa> IncidenciaOperativas { get; set; } = new List<IncidenciaOperativa>();

    public virtual Instructor? Instructor { get; set; }

    public virtual ICollection<MovimientoCaja> MovimientoCajas { get; set; } = new List<MovimientoCaja>();

    public virtual ICollection<MovimientoInventario> MovimientoInventarios { get; set; } = new List<MovimientoInventario>();

    public virtual ICollection<NotificacionLectura> NotificacionLecturas { get; set; } = new List<NotificacionLectura>();

    public virtual ICollection<Notificacion> Notificacions { get; set; } = new List<Notificacion>();

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    public virtual ICollection<ReservacionServicio> ReservacionServicios { get; set; } = new List<ReservacionServicio>();

    public virtual ICollection<Rutina> Rutinas { get; set; } = new List<Rutina>();

    public virtual ICollection<SaldoSocio> SaldoSocios { get; set; } = new List<SaldoSocio>();

    public virtual ICollection<TraspasoInventario> TraspasoInventarios { get; set; } = new List<TraspasoInventario>();

    public virtual ICollection<UsuarioRol> UsuarioRols { get; set; } = new List<UsuarioRol>();

    public virtual ICollection<UsuarioSucursal> UsuarioSucursals { get; set; } = new List<UsuarioSucursal>();

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
