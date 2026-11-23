using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class Gimnasio
{
    public int GimnasioId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Codigo { get; set; } = null!;

    public bool Activo { get; set; }

    public DateTime FechaRegistro { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public byte[] Version { get; set; } = null!;

    public virtual ICollection<Actividad> Actividads { get; set; } = new List<Actividad>();

    public virtual ICollection<AreaGimnasio> AreaGimnasios { get; set; } = new List<AreaGimnasio>();

    public virtual ICollection<Caja> Cajas { get; set; } = new List<Caja>();

    public virtual ICollection<CategoriaDocumento> CategoriaDocumentos { get; set; } = new List<CategoriaDocumento>();

    public virtual ICollection<CategoriaProducto> CategoriaProductos { get; set; } = new List<CategoriaProducto>();

    public virtual ICollection<CategoriaServicio> CategoriaServicios { get; set; } = new List<CategoriaServicio>();

    public virtual ICollection<Clase> Clases { get; set; } = new List<Clase>();

    public virtual ICollection<CompraProveedor> CompraProveedors { get; set; } = new List<CompraProveedor>();

    public virtual ICollection<Comunicado> Comunicados { get; set; } = new List<Comunicado>();

    public virtual ICollection<ConfiguracionGeneral> ConfiguracionGenerals { get; set; } = new List<ConfiguracionGeneral>();

    public virtual ConfiguracionMembresium? ConfiguracionMembresium { get; set; }

    public virtual ICollection<CorteCaja> CorteCajas { get; set; } = new List<CorteCaja>();

    public virtual ICollection<DetalleCompraProveedor> DetalleCompraProveedors { get; set; } = new List<DetalleCompraProveedor>();

    public virtual ICollection<DetalleTraspasoInventario> DetalleTraspasoInventarios { get; set; } = new List<DetalleTraspasoInventario>();

    public virtual ICollection<DiaRutina> DiaRutinas { get; set; } = new List<DiaRutina>();

    public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();

    public virtual ICollection<EjercicioRutina> EjercicioRutinas { get; set; } = new List<EjercicioRutina>();

    public virtual ICollection<Ejercicio> Ejercicios { get; set; } = new List<Ejercicio>();

    public virtual ICollection<EvaluacionFisica> EvaluacionFisicas { get; set; } = new List<EvaluacionFisica>();

    public virtual ICollection<ExcepcionHorarioSucursal> ExcepcionHorarioSucursals { get; set; } = new List<ExcepcionHorarioSucursal>();

    public virtual ICollection<HistorialObjetivoFisico> HistorialObjetivoFisicos { get; set; } = new List<HistorialObjetivoFisico>();

    public virtual ICollection<HorarioSucursal> HorarioSucursals { get; set; } = new List<HorarioSucursal>();

    public virtual ICollection<IncidenciaOperativa> IncidenciaOperativas { get; set; } = new List<IncidenciaOperativa>();

    public virtual ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();

    public virtual ICollection<InventarioSucursal> InventarioSucursals { get; set; } = new List<InventarioSucursal>();

    public virtual ICollection<Marca> Marcas { get; set; } = new List<Marca>();

    public virtual ICollection<MembresiaSocio> MembresiaSocios { get; set; } = new List<MembresiaSocio>();

    public virtual ICollection<MovimientoCaja> MovimientoCajas { get; set; } = new List<MovimientoCaja>();

    public virtual ICollection<MovimientoInventario> MovimientoInventarios { get; set; } = new List<MovimientoInventario>();

    public virtual ICollection<Notificacion> Notificacions { get; set; } = new List<Notificacion>();

    public virtual ICollection<ObjetivoFisico> ObjetivoFisicos { get; set; } = new List<ObjetivoFisico>();

    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    public virtual ICollection<ParametroConfiguracion> ParametroConfiguracions { get; set; } = new List<ParametroConfiguracion>();

    public virtual PerfilGimnasio? PerfilGimnasio { get; set; }

    public virtual ICollection<PlanMembresium> PlanMembresia { get; set; } = new List<PlanMembresium>();

    public virtual ICollection<PlantillaNotificacion> PlantillaNotificacions { get; set; } = new List<PlantillaNotificacion>();

    public virtual ICollection<PoliticaGimnasio> PoliticaGimnasios { get; set; } = new List<PoliticaGimnasio>();

    public virtual ICollection<ProductoProveedor> ProductoProveedors { get; set; } = new List<ProductoProveedor>();

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    public virtual ICollection<Proveedor> Proveedors { get; set; } = new List<Proveedor>();

    public virtual ICollection<Rol> Rols { get; set; } = new List<Rol>();

    public virtual ICollection<RutinaSocio> RutinaSocios { get; set; } = new List<RutinaSocio>();

    public virtual ICollection<Rutina> Rutinas { get; set; } = new List<Rutina>();

    public virtual ICollection<SaldoSocio> SaldoSocios { get; set; } = new List<SaldoSocio>();

    public virtual ICollection<SeguimientoEjercicio> SeguimientoEjercicios { get; set; } = new List<SeguimientoEjercicio>();

    public virtual ICollection<Socio> Socios { get; set; } = new List<Socio>();

    public virtual Sucursal? Sucursal { get; set; }

    public virtual ICollection<TraspasoInventario> TraspasoInventarios { get; set; } = new List<TraspasoInventario>();

    public virtual ICollection<UnidadMedidum> UnidadMedida { get; set; } = new List<UnidadMedidum>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();

    public virtual ICollection<VisitaSocio> VisitaSocios { get; set; } = new List<VisitaSocio>();
}
