using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class Sucursal
{
    public int SucursalId { get; set; }

    public int GimnasioId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public string? Direccion { get; set; }

    public string? CodigoPostal { get; set; }

    public string? Municipio { get; set; }

    public string? Estado { get; set; }

    public bool EsPrincipal { get; set; }

    public DateOnly? FechaApertura { get; set; }

    public bool Activo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public byte[] Version { get; set; } = null!;

    public virtual ICollection<AccesoSocio> AccesoSocios { get; set; } = new List<AccesoSocio>();

    public virtual ICollection<ActividadProgramadum> ActividadProgramada { get; set; } = new List<ActividadProgramadum>();

    public virtual ICollection<AreaClase> AreaClases { get; set; } = new List<AreaClase>();

    public virtual ICollection<AreaGimnasio> AreaGimnasios { get; set; } = new List<AreaGimnasio>();

    public virtual ICollection<Caja> Cajas { get; set; } = new List<Caja>();

    public virtual ICollection<CompraProveedor> CompraProveedors { get; set; } = new List<CompraProveedor>();

    public virtual ICollection<Comunicado> Comunicados { get; set; } = new List<Comunicado>();

    public virtual ICollection<ContratacionServicio> ContratacionServicios { get; set; } = new List<ContratacionServicio>();

    public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();

    public virtual ICollection<ExcepcionHorarioSucursal> ExcepcionHorarioSucursals { get; set; } = new List<ExcepcionHorarioSucursal>();

    public virtual CatGimnasio Gimnasio { get; set; } = null!;

    public virtual ICollection<HorarioClase> HorarioClases { get; set; } = new List<HorarioClase>();

    public virtual ICollection<HorarioSucursal> HorarioSucursals { get; set; } = new List<HorarioSucursal>();

    public virtual ICollection<IncidenciaOperativa> IncidenciaOperativas { get; set; } = new List<IncidenciaOperativa>();

    public virtual ICollection<InventarioSucursal> InventarioSucursals { get; set; } = new List<InventarioSucursal>();

    public virtual ICollection<MembresiaSocio> MembresiaSocios { get; set; } = new List<MembresiaSocio>();

    public virtual ICollection<MembresiaSucursal> MembresiaSucursals { get; set; } = new List<MembresiaSucursal>();

    public virtual ICollection<MovimientoInventario> MovimientoInventarios { get; set; } = new List<MovimientoInventario>();

    public virtual ICollection<Notificacion> Notificacions { get; set; } = new List<Notificacion>();

    public virtual ICollection<ServicioSucursal> ServicioSucursals { get; set; } = new List<ServicioSucursal>();

    public virtual ICollection<Socio> Socios { get; set; } = new List<Socio>();

    public virtual ICollection<TraspasoInventario> TraspasoInventarioSucursalNavigations { get; set; } = new List<TraspasoInventario>();

    public virtual ICollection<TraspasoInventario> TraspasoInventarioSucursals { get; set; } = new List<TraspasoInventario>();

    public virtual ICollection<UsuarioSucursal> UsuarioSucursals { get; set; } = new List<UsuarioSucursal>();

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();

    public virtual ICollection<VisitaSocio> VisitaSocios { get; set; } = new List<VisitaSocio>();
}
