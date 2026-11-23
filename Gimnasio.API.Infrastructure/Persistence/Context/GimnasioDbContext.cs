using System;
using System.Collections.Generic;
using Gimnasio.API.Infrastructure.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace Gimnasio.API.Infrastructure.Persistence.Context;

public partial class GimnasioDbContext : DbContext
{
    public GimnasioDbContext(DbContextOptions<GimnasioDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccesoSocio> AccesoSocios { get; set; }

    public virtual DbSet<Actividad> Actividads { get; set; }

    public virtual DbSet<ActividadProgramadum> ActividadProgramada { get; set; }

    public virtual DbSet<AreaClase> AreaClases { get; set; }

    public virtual DbSet<AreaGimnasio> AreaGimnasios { get; set; }

    public virtual DbSet<AsistenciaActividad> AsistenciaActividads { get; set; }

    public virtual DbSet<AsistenciaClase> AsistenciaClases { get; set; }

    public virtual DbSet<Caja> Cajas { get; set; }

    public virtual DbSet<CategoriaDocumento> CategoriaDocumentos { get; set; }

    public virtual DbSet<CategoriaProducto> CategoriaProductos { get; set; }

    public virtual DbSet<CategoriaServicio> CategoriaServicios { get; set; }

    public virtual DbSet<CategoriaVentum> CategoriaVenta { get; set; }

    public virtual DbSet<Clase> Clases { get; set; }

    public virtual DbSet<CompraProveedor> CompraProveedors { get; set; }

    public virtual DbSet<Comunicado> Comunicados { get; set; }

    public virtual DbSet<ComunicadoLectura> ComunicadoLecturas { get; set; }

    public virtual DbSet<ConfiguracionGeneral> ConfiguracionGenerals { get; set; }

    public virtual DbSet<ConfiguracionMembresium> ConfiguracionMembresia { get; set; }

    public virtual DbSet<ContratacionServicio> ContratacionServicios { get; set; }

    public virtual DbSet<CorteCaja> CorteCajas { get; set; }

    public virtual DbSet<DetalleCompraProveedor> DetalleCompraProveedors { get; set; }

    public virtual DbSet<DetalleTraspasoInventario> DetalleTraspasoInventarios { get; set; }

    public virtual DbSet<DetalleVentum> DetalleVenta { get; set; }

    public virtual DbSet<DiaRutina> DiaRutinas { get; set; }

    public virtual DbSet<DiaSemana> DiaSemanas { get; set; }

    public virtual DbSet<Documento> Documentos { get; set; }

    public virtual DbSet<Ejercicio> Ejercicios { get; set; }

    public virtual DbSet<EjercicioRutina> EjercicioRutinas { get; set; }

    public virtual DbSet<EvaluacionFisica> EvaluacionFisicas { get; set; }

    public virtual DbSet<ExcepcionHorarioSucursal> ExcepcionHorarioSucursals { get; set; }

    public virtual DbSet<GrupoMuscular> GrupoMusculars { get; set; }

    public virtual DbSet<HistorialMembresium> HistorialMembresia { get; set; }

    public virtual DbSet<HistorialNotificacion> HistorialNotificacions { get; set; }

    public virtual DbSet<HistorialObjetivoFisico> HistorialObjetivoFisicos { get; set; }

    public virtual DbSet<HorarioClase> HorarioClases { get; set; }

    public virtual DbSet<HorarioSucursal> HorarioSucursals { get; set; }

    public virtual DbSet<IncidenciaOperativa> IncidenciaOperativas { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<InventarioSucursal> InventarioSucursals { get; set; }

    public virtual DbSet<ListaEsperaClase> ListaEsperaClases { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<MembresiaSocio> MembresiaSocios { get; set; }

    public virtual DbSet<MembresiaSucursal> MembresiaSucursals { get; set; }

    public virtual DbSet<MetodoPago> MetodoPagos { get; set; }

    public virtual DbSet<MovimientoCaja> MovimientoCajas { get; set; }

    public virtual DbSet<MovimientoInventario> MovimientoInventarios { get; set; }

    public virtual DbSet<Notificacion> Notificacions { get; set; }

    public virtual DbSet<NotificacionLectura> NotificacionLecturas { get; set; }

    public virtual DbSet<ObjetivoFisico> ObjetivoFisicos { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<ParametroConfiguracion> ParametroConfiguracions { get; set; }

    public virtual DbSet<PerfilGimnasio> PerfilGimnasios { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<PlanMembresium> PlanMembresia { get; set; }

    public virtual DbSet<PlantillaNotificacion> PlantillaNotificacions { get; set; }

    public virtual DbSet<PoliticaGimnasio> PoliticaGimnasios { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductoProveedor> ProductoProveedors { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<ReservacionActividad> ReservacionActividads { get; set; }

    public virtual DbSet<ReservacionClase> ReservacionClases { get; set; }

    public virtual DbSet<ReservacionServicio> ReservacionServicios { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<RolPermiso> RolPermisos { get; set; }

    public virtual DbSet<Rutina> Rutinas { get; set; }

    public virtual DbSet<RutinaSocio> RutinaSocios { get; set; }

    public virtual DbSet<SaldoSocio> SaldoSocios { get; set; }

    public virtual DbSet<SeguimientoEjercicio> SeguimientoEjercicios { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<ServicioSucursal> ServicioSucursals { get; set; }

    public virtual DbSet<SesionClase> SesionClases { get; set; }

    public virtual DbSet<Socio> Socios { get; set; }

    public virtual DbSet<Sucursal> Sucursals { get; set; }

    public virtual DbSet<TipoClase> TipoClases { get; set; }

    public virtual DbSet<TipoNotificacion> TipoNotificacions { get; set; }

    public virtual DbSet<TraspasoInventario> TraspasoInventarios { get; set; }

    public virtual DbSet<UnidadMedidum> UnidadMedida { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuarioRol> UsuarioRols { get; set; }

    public virtual DbSet<UsuarioSucursal> UsuarioSucursals { get; set; }

    public virtual DbSet<Ventum> Venta { get; set; }

    public virtual DbSet<VisitaSocio> VisitaSocios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccesoSocio>(entity =>
        {
            entity.ToTable("AccesoSocio");

            entity.HasIndex(e => new { e.MembresiaSocioId, e.FechaAcceso }, "IX_AccesoSocio_Membresia").IsDescending(false, true);

            entity.HasIndex(e => new { e.SocioId, e.FechaAcceso }, "IX_AccesoSocio_Socio").IsDescending(false, true);

            entity.HasIndex(e => new { e.SucursalId, e.FechaAcceso }, "IX_AccesoSocio_Sucursal").IsDescending(false, true);

            entity.Property(e => e.FechaAcceso)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.MetodoIdentificacion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Manual");
            entity.Property(e => e.Observaciones).HasMaxLength(250);
            entity.Property(e => e.Resultado)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TipoAcceso)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.MembresiaSocio).WithMany(p => p.AccesoSocios)
                .HasForeignKey(d => d.MembresiaSocioId)
                .HasConstraintName("FK_AccesoSocio_Membresia");

            entity.HasOne(d => d.Socio).WithMany(p => p.AccesoSocios)
                .HasForeignKey(d => d.SocioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccesoSocio_Socio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.AccesoSocios)
                .HasForeignKey(d => d.SucursalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccesoSocio_Sucursal");

            entity.HasOne(d => d.Usuario).WithMany(p => p.AccesoSocios)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK_AccesoSocio_Usuario");
        });

        modelBuilder.Entity<Actividad>(entity =>
        {
            entity.HasKey(e => e.ActividadId).HasName("PK__Activida__98148390BDA85EF7");

            entity.ToTable("Actividad");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.TipoActividad).HasMaxLength(30);
        });

        modelBuilder.Entity<ActividadProgramadum>(entity =>
        {
            entity.HasKey(e => e.ActividadProgramadaId).HasName("PK__Activida__EEFCF512AC52BA94");

            entity.HasIndex(e => e.ActividadId, "IX_ActividadProgramada_Actividad");

            entity.HasIndex(e => new { e.SucursalId, e.FechaInicio }, "IX_ActividadProgramada_Sucursal_Fecha");

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Programada");
            entity.Property(e => e.Observaciones).HasMaxLength(500);

            entity.HasOne(d => d.Actividad).WithMany(p => p.ActividadProgramada)
                .HasForeignKey(d => d.ActividadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActividadProgramada_Actividad");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.ActividadProgramada)
                .HasForeignKey(d => d.SucursalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActividadProgramada_Sucursal");

            entity.HasOne(d => d.UsuarioResponsable).WithMany(p => p.ActividadProgramada)
                .HasForeignKey(d => d.UsuarioResponsableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActividadProgramada_Usuario");
        });

        modelBuilder.Entity<AreaClase>(entity =>
        {
            entity.ToTable("AreaClase");

            entity.HasIndex(e => new { e.SucursalId, e.Nombre }, "UQ_AreaClase_Sucursal").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Sucursal).WithMany(p => p.AreaClases)
                .HasForeignKey(d => d.SucursalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AreaClase_Sucursal");
        });

        modelBuilder.Entity<AreaGimnasio>(entity =>
        {
            entity.ToTable("AreaGimnasio");

            entity.HasIndex(e => new { e.SucursalId, e.Activo }, "IX_AreaGimnasio_Sucursal");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Sucursal).WithMany(p => p.AreaGimnasios)
                .HasForeignKey(d => d.SucursalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AreaGimnasio_Sucursal");
        });

        modelBuilder.Entity<AsistenciaActividad>(entity =>
        {
            entity.HasKey(e => e.AsistenciaActividadId).HasName("PK__Asistenc__19E615CC6CC00976");

            entity.ToTable("AsistenciaActividad");

            entity.HasIndex(e => e.ReservacionActividadId, "UQ_AsistenciaActividad_Reservacion").IsUnique();

            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.ReservacionActividad).WithOne(p => p.AsistenciaActividad)
                .HasForeignKey<AsistenciaActividad>(d => d.ReservacionActividadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AsistenciaActividad_Reservacion");

            entity.HasOne(d => d.UsuarioRegistro).WithMany(p => p.AsistenciaActividads)
                .HasForeignKey(d => d.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AsistenciaActividad_Usuario");
        });

        modelBuilder.Entity<AsistenciaClase>(entity =>
        {
            entity.ToTable("AsistenciaClase");

            entity.HasIndex(e => e.ReservacionClaseId, "UQ_AsistenciaClase_Reservacion").IsUnique();

            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Observaciones).HasMaxLength(250);

            entity.HasOne(d => d.ReservacionClase).WithOne(p => p.AsistenciaClase)
                .HasForeignKey<AsistenciaClase>(d => d.ReservacionClaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AsistenciaClase_Reservacion");

            entity.HasOne(d => d.UsuarioRegistro).WithMany(p => p.AsistenciaClases)
                .HasForeignKey(d => d.UsuarioRegistroId)
                .HasConstraintName("FK_AsistenciaClase_Usuario");
        });

        modelBuilder.Entity<Caja>(entity =>
        {
            entity.ToTable("Caja");

            entity.HasIndex(e => new { e.SucursalId, e.Activo }, "IX_Caja_Sucursal");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Sucursal).WithMany(p => p.Cajas)
                .HasForeignKey(d => d.SucursalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Caja_Sucursal");
        });

        modelBuilder.Entity<CategoriaDocumento>(entity =>
        {
            entity.HasKey(e => e.CategoriaDocumentoId).HasName("PK__Categori__E7EDE9FE95A2588D");

            entity.ToTable("CategoriaDocumento");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<CategoriaProducto>(entity =>
        {
            entity.ToTable("CategoriaProducto");

            entity.HasIndex(e => e.Nombre, "UQ_CategoriaProducto_Nombre").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<CategoriaServicio>(entity =>
        {
            entity.HasKey(e => e.CategoriaServicioId).HasName("PK__Categori__5D7B57C3C679C39A");

            entity.ToTable("CategoriaServicio");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<CategoriaVentum>(entity =>
        {
            entity.HasKey(e => e.CategoriaVentaId);

            entity.HasIndex(e => e.Nombre, "UQ_CategoriaVenta_Nombre").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Clase>(entity =>
        {
            entity.ToTable("Clase");

            entity.HasIndex(e => new { e.TipoClaseId, e.Activo }, "IX_Clase_Tipo");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Nombre).HasMaxLength(150);

            entity.HasOne(d => d.TipoClase).WithMany(p => p.Clases)
                .HasForeignKey(d => d.TipoClaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Clase_TipoClase");
        });

        modelBuilder.Entity<CompraProveedor>(entity =>
        {
            entity.ToTable("CompraProveedor");

            entity.HasIndex(e => new { e.SucursalId, e.FechaCompra }, "IX_CompraProveedor_Fecha").IsDescending(false, true);

            entity.HasIndex(e => e.Folio, "UQ_CompraProveedor_Folio").IsUnique();

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Pendiente");
            entity.Property(e => e.FechaCompra)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Folio)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Impuesto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.CompraProveedors)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompraProveedor_Proveedor");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.CompraProveedors)
                .HasForeignKey(d => d.SucursalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompraProveedor_Sucursal");

            entity.HasOne(d => d.Usuario).WithMany(p => p.CompraProveedors)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompraProveedor_Usuario");
        });

        modelBuilder.Entity<Comunicado>(entity =>
        {
            entity.HasKey(e => e.ComunicadoId).HasName("PK__Comunica__BC7B865783A456E6");

            entity.ToTable("Comunicado");

            entity.HasIndex(e => new { e.Estado, e.FechaPublicacion }, "IX_Comunicado_Estado_Fecha").IsDescending(false, true);

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Borrador");
            entity.Property(e => e.PublicoObjetivo)
                .HasMaxLength(20)
                .HasDefaultValue("Todos");
            entity.Property(e => e.Titulo).HasMaxLength(200);

            entity.HasOne(d => d.Sucursal).WithMany(p => p.Comunicados)
                .HasForeignKey(d => d.SucursalId)
                .HasConstraintName("FK_Comunicado_Sucursal");

            entity.HasOne(d => d.UsuarioCreador).WithMany(p => p.Comunicados)
                .HasForeignKey(d => d.UsuarioCreadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comunicado_Usuario");
        });

        modelBuilder.Entity<ComunicadoLectura>(entity =>
        {
            entity.HasKey(e => e.ComunicadoLecturaId).HasName("PK__Comunica__F0579785222CDF81");

            entity.ToTable("ComunicadoLectura");

            entity.HasIndex(e => new { e.ComunicadoId, e.SocioId }, "UX_ComunicadoLectura_Socio")
                .IsUnique()
                .HasFilter("([SocioId] IS NOT NULL)");

            entity.HasIndex(e => new { e.ComunicadoId, e.UsuarioId }, "UX_ComunicadoLectura_Usuario")
                .IsUnique()
                .HasFilter("([UsuarioId] IS NOT NULL)");

            entity.Property(e => e.FechaLectura).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.Comunicado).WithMany(p => p.ComunicadoLecturas)
                .HasForeignKey(d => d.ComunicadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ComunicadoLectura_Comunicado");

            entity.HasOne(d => d.Socio).WithMany(p => p.ComunicadoLecturas)
                .HasForeignKey(d => d.SocioId)
                .HasConstraintName("FK_ComunicadoLectura_Socio");

            entity.HasOne(d => d.Usuario).WithMany(p => p.ComunicadoLecturas)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK_ComunicadoLectura_Usuario");
        });

        modelBuilder.Entity<ConfiguracionGeneral>(entity =>
        {
            entity.HasKey(e => e.ConfiguracionGeneralId).HasName("PK__Configur__7BA561F724707953");

            entity.ToTable("ConfiguracionGeneral");

            entity.Property(e => e.ConfiguracionGeneralId).ValueGeneratedNever();
            entity.Property(e => e.DiasAnticipacionVencimiento).HasDefaultValue(3);
            entity.Property(e => e.FechaActualizacion).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.FormatoFecha)
                .HasMaxLength(20)
                .HasDefaultValue("dd/MM/yyyy");
            entity.Property(e => e.FormatoHora)
                .HasMaxLength(10)
                .HasDefaultValue("24H");
            entity.Property(e => e.Idioma)
                .HasMaxLength(10)
                .HasDefaultValue("es-MX");
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .HasDefaultValue("MXN");
            entity.Property(e => e.NotificarMembresiaPorVencer).HasDefaultValue(true);
            entity.Property(e => e.NotificarMembresiaVencida).HasDefaultValue(true);
            entity.Property(e => e.Pais)
                .HasMaxLength(100)
                .HasDefaultValue("México");
            entity.Property(e => e.PermitirAccesoSocios).HasDefaultValue(true);
            entity.Property(e => e.PermitirReservaciones).HasDefaultValue(true);
            entity.Property(e => e.PermitirSaldoAfavor)
                .HasDefaultValue(true)
                .HasColumnName("PermitirSaldoAFavor");
            entity.Property(e => e.PermitirVentaSinSocio).HasDefaultValue(true);
            entity.Property(e => e.ZonaHoraria)
                .HasMaxLength(100)
                .HasDefaultValue("America/Mexico_City");
        });

        modelBuilder.Entity<ConfiguracionMembresium>(entity =>
        {
            entity.HasKey(e => e.ConfiguracionMembresiaId);

            entity.Property(e => e.ConservarDiasRestantes).HasDefaultValue(true);
            entity.Property(e => e.FechaActualizacion).HasPrecision(0);
            entity.Property(e => e.PermitirCambiosPlan).HasDefaultValue(true);
            entity.Property(e => e.PermitirCancelarFuturas).HasDefaultValue(true);
            entity.Property(e => e.PoliticaCambioPlanMayor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("COBRAR_DIFERENCIA");
            entity.Property(e => e.PoliticaCambioPlanMenor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("SIN_DEVOLUCION");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<ContratacionServicio>(entity =>
        {
            entity.HasKey(e => e.ContratacionServicioId).HasName("PK__Contrata__FEFC7BCFEC97AA22");

            entity.ToTable("ContratacionServicio");

            entity.HasIndex(e => e.ServicioId, "IX_ContratacionServicio_Servicio");

            entity.HasIndex(e => new { e.SocioId, e.Estado }, "IX_ContratacionServicio_Socio");

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Activa");
            entity.Property(e => e.FechaContratacion).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.PrecioAplicado).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Servicio).WithMany(p => p.ContratacionServicios)
                .HasForeignKey(d => d.ServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContratacionServicio_Servicio");

            entity.HasOne(d => d.Socio).WithMany(p => p.ContratacionServicios)
                .HasForeignKey(d => d.SocioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContratacionServicio_Socio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.ContratacionServicios)
                .HasForeignKey(d => d.SucursalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContratacionServicio_Sucursal");

            entity.HasOne(d => d.UsuarioRegistro).WithMany(p => p.ContratacionServicios)
                .HasForeignKey(d => d.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContratacionServicio_Usuario");

            entity.HasOne(d => d.Venta).WithMany(p => p.ContratacionServicios)
                .HasForeignKey(d => d.VentaId)
                .HasConstraintName("FK_ContratacionServicio_Venta");
        });

        modelBuilder.Entity<CorteCaja>(entity =>
        {
            entity.ToTable("CorteCaja");

            entity.HasIndex(e => e.CajaId, "UX_CorteCaja_Abierto")
                .IsUnique()
                .HasFilter("([Estado]='Abierta')");

            entity.Property(e => e.Diferencia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Estado)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("Abierta");
            entity.Property(e => e.FechaApertura)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.FechaCierre).HasPrecision(0);
            entity.Property(e => e.MontoEsperado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoInicial).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoReal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Observaciones).HasMaxLength(500);

            entity.HasOne(d => d.Caja).WithOne(p => p.CorteCaja)
                .HasForeignKey<CorteCaja>(d => d.CajaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CorteCaja_Caja");

            entity.HasOne(d => d.UsuarioApertura).WithMany(p => p.CorteCajaUsuarioAperturas)
                .HasForeignKey(d => d.UsuarioAperturaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CorteCaja_UsuarioApertura");

            entity.HasOne(d => d.UsuarioCierre).WithMany(p => p.CorteCajaUsuarioCierres)
                .HasForeignKey(d => d.UsuarioCierreId)
                .HasConstraintName("FK_CorteCaja_UsuarioCierre");
        });

        modelBuilder.Entity<DetalleCompraProveedor>(entity =>
        {
            entity.ToTable("DetalleCompraProveedor");

            entity.HasIndex(e => e.CompraProveedorId, "IX_DetalleCompra_Compra");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Impuesto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.CompraProveedor).WithMany(p => p.DetalleCompraProveedors)
                .HasForeignKey(d => d.CompraProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleCompra_Compra");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetalleCompraProveedors)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleCompra_Producto");
        });

        modelBuilder.Entity<DetalleTraspasoInventario>(entity =>
        {
            entity.ToTable("DetalleTraspasoInventario");

            entity.HasIndex(e => new { e.TraspasoInventarioId, e.ProductoId }, "UQ_DetalleTraspaso_Producto").IsUnique();

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetalleTraspasoInventarios)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleTraspaso_Producto");

            entity.HasOne(d => d.TraspasoInventario).WithMany(p => p.DetalleTraspasoInventarios)
                .HasForeignKey(d => d.TraspasoInventarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleTraspaso_Traspaso");
        });

        modelBuilder.Entity<DetalleVentum>(entity =>
        {
            entity.HasKey(e => e.DetalleVentaId);

            entity.HasIndex(e => e.VentaId, "IX_DetalleVenta_Venta");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Impuesto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.CategoriaVenta).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.CategoriaVentaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleVenta_Categoria");

            entity.HasOne(d => d.MembresiaSocio).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.MembresiaSocioId)
                .HasConstraintName("FK_DetalleVenta_Membresia");

            entity.HasOne(d => d.PlanMembresia).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.PlanMembresiaId)
                .HasConstraintName("FK_DetalleVenta_Plan");

            entity.HasOne(d => d.Venta).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.VentaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleVenta_Venta");
        });

        modelBuilder.Entity<DiaRutina>(entity =>
        {
            entity.HasKey(e => e.DiaRutinaId).HasName("PK__DiaRutin__2202F1EE03BE9716");

            entity.ToTable("DiaRutina");

            entity.HasIndex(e => e.RutinaId, "IX_DiaRutina_Rutina");

            entity.HasIndex(e => new { e.RutinaId, e.Orden }, "UQ_DiaRutina_Rutina_Orden").IsUnique();

            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.DiaSemana).WithMany(p => p.DiaRutinas)
                .HasForeignKey(d => d.DiaSemanaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiaRutina_DiaSemana");

            entity.HasOne(d => d.Rutina).WithMany(p => p.DiaRutinas)
                .HasForeignKey(d => d.RutinaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiaRutina_Rutina");
        });

        modelBuilder.Entity<DiaSemana>(entity =>
        {
            entity.ToTable("DiaSemana");

            entity.HasIndex(e => e.Nombre, "UQ_DiaSemana_Nombre").IsUnique();

            entity.Property(e => e.DiaSemanaId).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(20);
        });

        modelBuilder.Entity<Documento>(entity =>
        {
            entity.HasKey(e => e.DocumentoId).HasName("PK__Document__5DDBFC76165FC642");

            entity.ToTable("Documento");

            entity.HasIndex(e => e.CategoriaDocumentoId, "IX_Documento_Categoria");

            entity.HasIndex(e => new { e.SocioId, e.FechaCarga }, "IX_Documento_Socio").IsDescending(false, true);

            entity.HasIndex(e => new { e.UsuarioId, e.FechaCarga }, "IX_Documento_Usuario").IsDescending(false, true);

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Activo");
            entity.Property(e => e.Extension).HasMaxLength(20);
            entity.Property(e => e.FechaCarga).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.NombreArchivo).HasMaxLength(255);
            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.RutaArchivo).HasMaxLength(1000);
            entity.Property(e => e.TipoMime).HasMaxLength(150);

            entity.HasOne(d => d.CategoriaDocumento).WithMany(p => p.Documentos)
                .HasForeignKey(d => d.CategoriaDocumentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Documento_Categoria");

            entity.HasOne(d => d.Socio).WithMany(p => p.Documentos)
                .HasForeignKey(d => d.SocioId)
                .HasConstraintName("FK_Documento_Socio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.Documentos)
                .HasForeignKey(d => d.SucursalId)
                .HasConstraintName("FK_Documento_Sucursal");

            entity.HasOne(d => d.UsuarioCarga).WithMany(p => p.DocumentoUsuarioCargas)
                .HasForeignKey(d => d.UsuarioCargaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Documento_UsuarioCarga");

            entity.HasOne(d => d.Usuario).WithMany(p => p.DocumentoUsuarios)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK_Documento_Usuario");
        });

        modelBuilder.Entity<Ejercicio>(entity =>
        {
            entity.HasKey(e => e.EjercicioId).HasName("PK__Ejercici__81222641A0524E51");

            entity.ToTable("Ejercicio");

            entity.HasIndex(e => e.GrupoMuscularId, "IX_Ejercicio_GrupoMuscular");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.EquipoNecesario).HasMaxLength(200);
            entity.Property(e => e.ImagenUrl).HasMaxLength(500);
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.TipoEjercicio).HasMaxLength(30);
            entity.Property(e => e.VideoUrl).HasMaxLength(500);

            entity.HasOne(d => d.GrupoMuscular).WithMany(p => p.Ejercicios)
                .HasForeignKey(d => d.GrupoMuscularId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ejercicio_GrupoMuscular");
        });

        modelBuilder.Entity<EjercicioRutina>(entity =>
        {
            entity.HasKey(e => e.EjercicioRutinaId).HasName("PK__Ejercici__5EE10BBFCC272F98");

            entity.ToTable("EjercicioRutina");

            entity.HasIndex(e => e.EjercicioId, "IX_EjercicioRutina_Ejercicio");

            entity.HasIndex(e => new { e.DiaRutinaId, e.Orden }, "UQ_EjercicioRutina_Dia_Orden").IsUnique();

            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.Peso).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Repeticiones).HasMaxLength(50);

            entity.HasOne(d => d.DiaRutina).WithMany(p => p.EjercicioRutinas)
                .HasForeignKey(d => d.DiaRutinaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EjercicioRutina_DiaRutina");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.EjercicioRutinas)
                .HasForeignKey(d => d.EjercicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EjercicioRutina_Ejercicio");
        });

        modelBuilder.Entity<EvaluacionFisica>(entity =>
        {
            entity.HasKey(e => e.EvaluacionFisicaId).HasName("PK__Evaluaci__272F0C47F7EABC50");

            entity.ToTable("EvaluacionFisica");

            entity.HasIndex(e => new { e.SocioId, e.FechaEvaluacion }, "IX_EvaluacionFisica_Socio_Fecha").IsDescending(false, true);

            entity.Property(e => e.EstaturaCm).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.FechaEvaluacion).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Imc)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("IMC");
            entity.Property(e => e.MedidaBrazoCm).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MedidaCaderaCm).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MedidaCinturaCm).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MedidaPechoCm).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.MedidaPiernaCm).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.Observaciones).HasMaxLength(1000);
            entity.Property(e => e.PesoKg).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.PorcentajeGrasa).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PorcentajeMusculo).HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.Instructor).WithMany(p => p.EvaluacionFisicas)
                .HasForeignKey(d => d.InstructorId)
                .HasConstraintName("FK_EvaluacionFisica_Instructor");

            entity.HasOne(d => d.Socio).WithMany(p => p.EvaluacionFisicas)
                .HasForeignKey(d => d.SocioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EvaluacionFisica_Socio");

            entity.HasOne(d => d.UsuarioRegistro).WithMany(p => p.EvaluacionFisicas)
                .HasForeignKey(d => d.UsuarioRegistroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EvaluacionFisica_Usuario");
        });

        modelBuilder.Entity<ExcepcionHorarioSucursal>(entity =>
        {
            entity.ToTable("ExcepcionHorarioSucursal");

            entity.HasIndex(e => new { e.SucursalId, e.Fecha }, "UQ_ExcepcionHorarioSucursal").IsUnique();

            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.HoraApertura).HasPrecision(0);
            entity.Property(e => e.HoraCierre).HasPrecision(0);
            entity.Property(e => e.Motivo).HasMaxLength(250);

            entity.HasOne(d => d.Sucursal).WithMany(p => p.ExcepcionHorarioSucursals)
                .HasForeignKey(d => d.SucursalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExcepcionHorarioSucursal_Sucursal");
        });

        modelBuilder.Entity<GrupoMuscular>(entity =>
        {
            entity.HasKey(e => e.GrupoMuscularId).HasName("PK__GrupoMus__E484ED2D862DF419");

            entity.ToTable("GrupoMuscular");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<HistorialMembresium>(entity =>
        {
            entity.HasKey(e => e.HistorialMembresiaId);

            entity.HasIndex(e => new { e.MembresiaSocioId, e.FechaEvento }, "IX_HistorialMembresia_Membresia").IsDescending(false, true);

            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.EstadoAnterior)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EstadoNuevo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FechaEvento)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.TipoEvento)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.MembresiaSocio).WithMany(p => p.HistorialMembresia)
                .HasForeignKey(d => d.MembresiaSocioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistorialMembresia_Membresia");

            entity.HasOne(d => d.Usuario).WithMany(p => p.HistorialMembresia)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK_HistorialMembresia_Usuario");
        });

        modelBuilder.Entity<HistorialNotificacion>(entity =>
        {
            entity.HasKey(e => e.HistorialNotificacionId).HasName("PK__Historia__D948C3BA88B1B64D");

            entity.ToTable("HistorialNotificacion");

            entity.HasIndex(e => new { e.NotificacionId, e.FechaIntento }, "IX_HistorialNotificacion_Notificacion").IsDescending(false, true);

            entity.Property(e => e.Detalle).HasMaxLength(1000);
            entity.Property(e => e.FechaIntento).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Resultado).HasMaxLength(20);

            entity.HasOne(d => d.Notificacion).WithMany(p => p.HistorialNotificacions)
                .HasForeignKey(d => d.NotificacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistorialNotificacion_Notificacion");
        });

        modelBuilder.Entity<HistorialObjetivoFisico>(entity =>
        {
            entity.HasKey(e => e.HistorialObjetivoFisicoId).HasName("PK__Historia__280BBC2D871549DF");

            entity.ToTable("HistorialObjetivoFisico");

            entity.HasIndex(e => new { e.ObjetivoFisicoId, e.FechaRegistro }, "IX_HistorialObjetivoFisico_Objetivo_Fecha").IsDescending(false, true);

            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.ValorRegistrado).HasColumnType("decimal(8, 2)");

            entity.HasOne(d => d.ObjetivoFisico).WithMany(p => p.HistorialObjetivoFisicos)
                .HasForeignKey(d => d.ObjetivoFisicoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistorialObjetivoFisico_Objetivo");
        });

        modelBuilder.Entity<HorarioClase>(entity =>
        {
            entity.ToTable("HorarioClase");

            entity.HasIndex(e => new { e.InstructorId, e.DiaSemanaId, e.HoraInicio }, "IX_HorarioClase_Instructor");

            entity.HasIndex(e => new { e.SucursalId, e.DiaSemanaId, e.HoraInicio, e.Activo }, "IX_HorarioClase_SucursalDia");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.HoraFin).HasPrecision(0);
            entity.Property(e => e.HoraInicio).HasPrecision(0);

            entity.HasOne(d => d.AreaClase).WithMany(p => p.HorarioClases)
                .HasForeignKey(d => d.AreaClaseId)
                .HasConstraintName("FK_HorarioClase_Area");

            entity.HasOne(d => d.Clase).WithMany(p => p.HorarioClases)
                .HasForeignKey(d => d.ClaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HorarioClase_Clase");

            entity.HasOne(d => d.DiaSemana).WithMany(p => p.HorarioClases)
                .HasForeignKey(d => d.DiaSemanaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HorarioClase_Dia");

            entity.HasOne(d => d.Instructor).WithMany(p => p.HorarioClases)
                .HasForeignKey(d => d.InstructorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HorarioClase_Instructor");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.HorarioClases)
                .HasForeignKey(d => d.SucursalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HorarioClase_Sucursal");
        });

        modelBuilder.Entity<HorarioSucursal>(entity =>
        {
            entity.ToTable("HorarioSucursal");

            entity.HasIndex(e => new { e.SucursalId, e.DiaSemanaId }, "UQ_HorarioSucursal").IsUnique();

            entity.Property(e => e.HoraApertura).HasPrecision(0);
            entity.Property(e => e.HoraCierre).HasPrecision(0);

            entity.HasOne(d => d.DiaSemana).WithMany(p => p.HorarioSucursals)
                .HasForeignKey(d => d.DiaSemanaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HorarioSucursal_Dia");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.HorarioSucursals)
                .HasForeignKey(d => d.SucursalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HorarioSucursal_Sucursal");
        });

        modelBuilder.Entity<IncidenciaOperativa>(entity =>
        {
            entity.ToTable("IncidenciaOperativa");

            entity.HasIndex(e => new { e.SucursalId, e.Estado, e.FechaReporte }, "IX_Incidencia_Sucursal").IsDescending(false, false, true);

            entity.Property(e => e.Descripcion).HasMaxLength(1000);
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Abierta");
            entity.Property(e => e.FechaReporte)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.FechaResolucion).HasPrecision(0);
            entity.Property(e => e.ObservacionesResolucion).HasMaxLength(500);
            entity.Property(e => e.Prioridad)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("Media");
            entity.Property(e => e.Titulo).HasMaxLength(150);

            entity.HasOne(d => d.AreaGimnasio).WithMany(p => p.IncidenciaOperativas)
                .HasForeignKey(d => d.AreaGimnasioId)
                .HasConstraintName("FK_Incidencia_Area");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.IncidenciaOperativas)
                .HasForeignKey(d => d.SucursalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Incidencia_Sucursal");

            entity.HasOne(d => d.Usuario).WithMany(p => p.IncidenciaOperativas)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK_Incidencia_Usuario");
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.ToTable("Instructor");

            entity.HasIndex(e => new { e.ApellidoPaterno, e.Nombre }, "IX_Instructor_Nombre");

            entity.HasIndex(e => e.UsuarioId, "UX_Instructor_Usuario")
                .IsUnique()
                .HasFilter("([UsuarioId] IS NOT NULL)");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.ApellidoMaterno).HasMaxLength(100);
            entity.Property(e => e.ApellidoPaterno).HasMaxLength(100);
            entity.Property(e => e.Biografia).HasMaxLength(500);
            entity.Property(e => e.Correo).HasMaxLength(150);
            entity.Property(e => e.Especialidad).HasMaxLength(150);
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(20);

            entity.HasOne(d => d.Usuario).WithOne(p => p.Instructor)
                .HasForeignKey<Instructor>(d => d.UsuarioId)
                .HasConstraintName("FK_Instructor_Usuario");
        });

        modelBuilder.Entity<InventarioSucursal>(entity =>
        {
            entity.ToTable("InventarioSucursal");

            entity.HasIndex(e => e.ProductoId, "IX_InventarioSucursal_Producto");

            entity.HasIndex(e => new { e.SucursalId, e.ProductoId }, "UQ_InventarioSucursal").IsUnique();

            entity.Property(e => e.Existencia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaActualizacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.StockReservado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.Producto).WithMany(p => p.InventarioSucursals)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventarioSucursal_Producto");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.InventarioSucursals)
                .HasForeignKey(d => d.SucursalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventarioSucursal_Sucursal");
        });

        modelBuilder.Entity<ListaEsperaClase>(entity =>
        {
            entity.ToTable("ListaEsperaClase");

            entity.HasIndex(e => new { e.SesionClaseId, e.Estado, e.FechaRegistro }, "IX_ListaEspera_Orden");

            entity.HasIndex(e => new { e.SesionClaseId, e.SocioId }, "UQ_ListaEspera_SocioSesion").IsUnique();

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("EnEspera");
            entity.Property(e => e.FechaNotificacion).HasPrecision(0);
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");

            entity.HasOne(d => d.SesionClase).WithMany(p => p.ListaEsperaClases)
                .HasForeignKey(d => d.SesionClaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ListaEspera_Sesion");

            entity.HasOne(d => d.Socio).WithMany(p => p.ListaEsperaClases)
                .HasForeignKey(d => d.SocioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ListaEspera_Socio");
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.ToTable("Marca");

            entity.HasIndex(e => e.Nombre, "UQ_Marca_Nombre").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<MembresiaSocio>(entity =>
        {
            entity.ToTable("MembresiaSocio");

            entity.HasIndex(e => e.MembresiaAnteriorId, "IX_MembresiaSocio_Anterior").HasFilter("([MembresiaAnteriorId] IS NOT NULL)");

            entity.HasIndex(e => new { e.Estado, e.FechaInicio, e.FechaFin }, "IX_MembresiaSocio_Estado");

            entity.HasIndex(e => e.PlanMembresiaId, "IX_MembresiaSocio_Plan");

            entity.HasIndex(e => new { e.SocioId, e.FechaInicio }, "IX_MembresiaSocio_Socio").IsDescending(false, true);

            entity.HasIndex(e => e.SucursalCompraId, "IX_MembresiaSocio_SucursalCompra");

            entity.Property(e => e.CuotaInscripcion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Programada");
            entity.Property(e => e.FechaContratacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.PrecioContratado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TipoOperacion)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.MembresiaAnterior).WithMany(p => p.InverseMembresiaAnterior)
                .HasForeignKey(d => d.MembresiaAnteriorId)
                .HasConstraintName("FK_MembresiaSocio_Anterior");

            entity.HasOne(d => d.PlanMembresia).WithMany(p => p.MembresiaSocios)
                .HasForeignKey(d => d.PlanMembresiaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MembresiaSocio_Plan");

            entity.HasOne(d => d.Socio).WithMany(p => p.MembresiaSocios)
                .HasForeignKey(d => d.SocioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MembresiaSocio_Socio");

            entity.HasOne(d => d.SucursalCompra).WithMany(p => p.MembresiaSocios)
                .HasForeignKey(d => d.SucursalCompraId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MembresiaSocio_Sucursal");
        });

        modelBuilder.Entity<MembresiaSucursal>(entity =>
        {
            entity.ToTable("MembresiaSucursal");

            entity.HasIndex(e => new { e.SucursalId, e.Activo }, "IX_MembresiaSucursal_Sucursal");

            entity.HasIndex(e => new { e.MembresiaSocioId, e.SucursalId }, "UQ_MembresiaSucursal").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaAsignacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");

            entity.HasOne(d => d.MembresiaSocio).WithMany(p => p.MembresiaSucursals)
                .HasForeignKey(d => d.MembresiaSocioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MembresiaSucursal_Membresia");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.MembresiaSucursals)
                .HasForeignKey(d => d.SucursalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MembresiaSucursal_Sucursal");
        });

        modelBuilder.Entity<MetodoPago>(entity =>
        {
            entity.ToTable("MetodoPago");

            entity.HasIndex(e => e.Codigo, "UQ_MetodoPago_Codigo").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Nombre).HasMaxLength(80);
        });

        modelBuilder.Entity<MovimientoCaja>(entity =>
        {
            entity.ToTable("MovimientoCaja");

            entity.HasIndex(e => new { e.CorteCajaId, e.FechaMovimiento }, "IX_MovimientoCaja_Corte").IsDescending(false, true);

            entity.Property(e => e.Concepto).HasMaxLength(150);
            entity.Property(e => e.FechaMovimiento)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Observaciones).HasMaxLength(250);
            entity.Property(e => e.TipoMovimiento)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.CorteCaja).WithMany(p => p.MovimientoCajas)
                .HasForeignKey(d => d.CorteCajaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientoCaja_Corte");

            entity.HasOne(d => d.Usuario).WithMany(p => p.MovimientoCajas)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientoCaja_Usuario");
        });

        modelBuilder.Entity<MovimientoInventario>(entity =>
        {
            entity.ToTable("MovimientoInventario");

            entity.HasIndex(e => new { e.ProductoId, e.SucursalId, e.FechaMovimiento }, "IX_MovimientoInventario_Producto").IsDescending(false, false, true);

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoUnitario).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ExistenciaAnterior).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ExistenciaNueva).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaMovimiento)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Motivo).HasMaxLength(250);
            entity.Property(e => e.TipoMovimiento)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.CompraProveedor).WithMany(p => p.MovimientoInventarios)
                .HasForeignKey(d => d.CompraProveedorId)
                .HasConstraintName("FK_MovimientoInventario_Compra");

            entity.HasOne(d => d.Producto).WithMany(p => p.MovimientoInventarios)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientoInventario_Producto");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.MovimientoInventarios)
                .HasForeignKey(d => d.SucursalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientoInventario_Sucursal");

            entity.HasOne(d => d.Usuario).WithMany(p => p.MovimientoInventarios)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientoInventario_Usuario");

            entity.HasOne(d => d.Venta).WithMany(p => p.MovimientoInventarios)
                .HasForeignKey(d => d.VentaId)
                .HasConstraintName("FK_MovimientoInventario_Venta");
        });

        modelBuilder.Entity<Notificacion>(entity =>
        {
            entity.HasKey(e => e.NotificacionId).HasName("PK__Notifica__BCC120245C8A89A9");

            entity.ToTable("Notificacion");

            entity.HasIndex(e => new { e.Estado, e.FechaProgramada }, "IX_Notificacion_Estado_Fecha");

            entity.HasIndex(e => new { e.SocioId, e.FechaEnvio }, "IX_Notificacion_Socio_Fecha").IsDescending(false, true);

            entity.Property(e => e.Canal).HasMaxLength(20);
            entity.Property(e => e.ErrorEnvio).HasMaxLength(1000);
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Pendiente");
            entity.Property(e => e.Titulo).HasMaxLength(200);

            entity.HasOne(d => d.PlantillaNotificacion).WithMany(p => p.Notificacions)
                .HasForeignKey(d => d.PlantillaNotificacionId)
                .HasConstraintName("FK_Notificacion_Plantilla");

            entity.HasOne(d => d.Socio).WithMany(p => p.Notificacions)
                .HasForeignKey(d => d.SocioId)
                .HasConstraintName("FK_Notificacion_Socio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.Notificacions)
                .HasForeignKey(d => d.SucursalId)
                .HasConstraintName("FK_Notificacion_Sucursal");

            entity.HasOne(d => d.TipoNotificacion).WithMany(p => p.Notificacions)
                .HasForeignKey(d => d.TipoNotificacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notificacion_Tipo");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Notificacions)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK_Notificacion_Usuario");
        });

        modelBuilder.Entity<NotificacionLectura>(entity =>
        {
            entity.HasKey(e => e.NotificacionLecturaId).HasName("PK__Notifica__9FC30A2F6742219E");

            entity.ToTable("NotificacionLectura");

            entity.HasIndex(e => new { e.NotificacionId, e.SocioId }, "UX_NotificacionLectura_Socio")
                .IsUnique()
                .HasFilter("([SocioId] IS NOT NULL)");

            entity.HasIndex(e => new { e.NotificacionId, e.UsuarioId }, "UX_NotificacionLectura_Usuario")
                .IsUnique()
                .HasFilter("([UsuarioId] IS NOT NULL)");

            entity.Property(e => e.FechaLectura).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.Notificacion).WithMany(p => p.NotificacionLecturas)
                .HasForeignKey(d => d.NotificacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NotificacionLectura_Notificacion");

            entity.HasOne(d => d.Socio).WithMany(p => p.NotificacionLecturas)
                .HasForeignKey(d => d.SocioId)
                .HasConstraintName("FK_NotificacionLectura_Socio");

            entity.HasOne(d => d.Usuario).WithMany(p => p.NotificacionLecturas)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK_NotificacionLectura_Usuario");
        });

        modelBuilder.Entity<ObjetivoFisico>(entity =>
        {
            entity.HasKey(e => e.ObjetivoFisicoId).HasName("PK__Objetivo__B709A1DCDE4A29D1");

            entity.ToTable("ObjetivoFisico");

            entity.HasIndex(e => new { e.SocioId, e.Estado }, "IX_ObjetivoFisico_Socio_Estado");

            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("EnProceso");
            entity.Property(e => e.FechaInicio).HasDefaultValueSql("(CONVERT([date],getdate()))");
            entity.Property(e => e.TipoObjetivo).HasMaxLength(50);
            entity.Property(e => e.UnidadMedida).HasMaxLength(30);
            entity.Property(e => e.ValorInicial).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ValorObjetivo).HasColumnType("decimal(8, 2)");

            entity.HasOne(d => d.Socio).WithMany(p => p.ObjetivoFisicos)
                .HasForeignKey(d => d.SocioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ObjetivoFisico_Socio");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.ToTable("Pago");

            entity.HasIndex(e => new { e.CorteCajaId, e.FechaPago }, "IX_Pago_CorteCaja").IsDescending(false, true);

            entity.HasIndex(e => new { e.VentaId, e.FechaPago }, "IX_Pago_Venta").IsDescending(false, true);

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Aplicado");
            entity.Property(e => e.FechaPago)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Observaciones).HasMaxLength(250);
            entity.Property(e => e.Referencia).HasMaxLength(100);

            entity.HasOne(d => d.CorteCaja).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.CorteCajaId)
                .HasConstraintName("FK_Pago_CorteCaja");

            entity.HasOne(d => d.MetodoPago).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.MetodoPagoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pago_Metodo");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pago_Usuario");

            entity.HasOne(d => d.Venta).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.VentaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pago_Venta");
        });

        modelBuilder.Entity<ParametroConfiguracion>(entity =>
        {
            entity.HasKey(e => e.ParametroConfiguracionId).HasName("PK__Parametr__82F2D3A45FAD78A9");

            entity.ToTable("ParametroConfiguracion");

            entity.HasIndex(e => e.Clave, "UQ_ParametroConfiguracion_Clave").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Clave).HasMaxLength(100);
            entity.Property(e => e.Descripcion).HasMaxLength(300);
            entity.Property(e => e.FechaActualizacion).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.TipoDato)
                .HasMaxLength(20)
                .HasDefaultValue("Texto");
        });

        modelBuilder.Entity<PerfilGimnasio>(entity =>
        {
            entity.ToTable("PerfilGimnasio");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Correo).HasMaxLength(150);
            entity.Property(e => e.Direccion).HasMaxLength(250);
            entity.Property(e => e.Estado).HasMaxLength(100);
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.LogotipoUrl).HasMaxLength(500);
            entity.Property(e => e.Municipio).HasMaxLength(100);
            entity.Property(e => e.NombreComercial).HasMaxLength(150);
            entity.Property(e => e.Pais)
                .HasMaxLength(100)
                .HasDefaultValue("México");
            entity.Property(e => e.RazonSocial).HasMaxLength(200);
            entity.Property(e => e.Rfc)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("RFC");
            entity.Property(e => e.Telefono).HasMaxLength(20);
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<Permiso>(entity =>
        {
            entity.ToTable("Permiso");

            entity.HasIndex(e => e.Codigo, "UQ_Permiso_Codigo").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Codigo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Modulo)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<PlanMembresium>(entity =>
        {
            entity.HasKey(e => e.PlanMembresiaId);

            entity.HasIndex(e => e.Activo, "IX_PlanMembresia_Activo");

            entity.HasIndex(e => e.Nombre, "UQ_PlanMembresia_Nombre").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.CuotaInscripcion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.FechaActualizacion).HasPrecision(0);
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UnidadDuracion)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<PlantillaNotificacion>(entity =>
        {
            entity.HasKey(e => e.PlantillaNotificacionId).HasName("PK__Plantill__003795FDD78B6150");

            entity.ToTable("PlantillaNotificacion");

            entity.HasIndex(e => e.TipoNotificacionId, "IX_PlantillaNotificacion_Tipo");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Asunto).HasMaxLength(200);
            entity.Property(e => e.Canal).HasMaxLength(20);
            entity.Property(e => e.Nombre).HasMaxLength(150);

            entity.HasOne(d => d.TipoNotificacion).WithMany(p => p.PlantillaNotificacions)
                .HasForeignKey(d => d.TipoNotificacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlantillaNotificacion_Tipo");
        });

        modelBuilder.Entity<PoliticaGimnasio>(entity =>
        {
            entity.HasKey(e => e.PoliticaGimnasioId).HasName("PK__Politica__A3B778AAE8430F6F");

            entity.ToTable("PoliticaGimnasio");

            entity.HasIndex(e => e.Clave, "UQ_PoliticaGimnasio_Clave").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Clave).HasMaxLength(100);
            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.FechaActualizacion).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.Valor).HasMaxLength(500);
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.ToTable("Producto");

            entity.HasIndex(e => new { e.CategoriaProductoId, e.Activo }, "IX_Producto_Categoria");

            entity.HasIndex(e => e.Nombre, "IX_Producto_Nombre");

            entity.HasIndex(e => e.CodigoBarras, "UX_Producto_CodigoBarras")
                .IsUnique()
                .HasFilter("([CodigoBarras] IS NOT NULL)");

            entity.HasIndex(e => e.Sku, "UX_Producto_SKU")
                .IsUnique()
                .HasFilter("([SKU] IS NOT NULL)");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.CodigoBarras)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ControlarInventario).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.FechaActualizacion).HasPrecision(0);
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.ImagenUrl).HasMaxLength(500);
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.PorcentajeImpuesto).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PrecioCompra).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioVenta).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SKU");
            entity.Property(e => e.StockMinimo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.CategoriaProducto).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CategoriaProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Producto_Categoria");

            entity.HasOne(d => d.Marca).WithMany(p => p.Productos)
                .HasForeignKey(d => d.MarcaId)
                .HasConstraintName("FK_Producto_Marca");

            entity.HasOne(d => d.UnidadMedida).WithMany(p => p.Productos)
                .HasForeignKey(d => d.UnidadMedidaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Producto_Unidad");
        });

        modelBuilder.Entity<ProductoProveedor>(entity =>
        {
            entity.HasKey(e => new { e.ProductoId, e.ProveedorId });

            entity.ToTable("ProductoProveedor");

            entity.Property(e => e.CodigoProductoProveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrecioCompra).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Producto).WithMany(p => p.ProductoProveedors)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoProveedor_Producto");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.ProductoProveedors)
                .HasForeignKey(d => d.ProveedorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoProveedor_Proveedor");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.ToTable("Proveedor");

            entity.HasIndex(e => e.Nombre, "IX_Proveedor_Nombre");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Contacto).HasMaxLength(150);
            entity.Property(e => e.Correo).HasMaxLength(150);
            entity.Property(e => e.Direccion).HasMaxLength(250);
            entity.Property(e => e.Estado).HasMaxLength(100);
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Municipio).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.RazonSocial).HasMaxLength(200);
            entity.Property(e => e.Rfc)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("RFC");
            entity.Property(e => e.Telefono).HasMaxLength(20);
        });

        modelBuilder.Entity<ReservacionActividad>(entity =>
        {
            entity.HasKey(e => e.ReservacionActividadId).HasName("PK__Reservac__68D3BCAC71307BC1");

            entity.ToTable("ReservacionActividad");

            entity.HasIndex(e => new { e.SocioId, e.FechaReservacion }, "IX_ReservacionActividad_Socio");

            entity.HasIndex(e => new { e.ActividadProgramadaId, e.SocioId }, "UQ_ReservacionActividad_Socio").IsUnique();

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Reservada");
            entity.Property(e => e.FechaReservacion).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Observaciones).HasMaxLength(300);

            entity.HasOne(d => d.ActividadProgramada).WithMany(p => p.ReservacionActividads)
                .HasForeignKey(d => d.ActividadProgramadaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReservacionActividad_Actividad");

            entity.HasOne(d => d.Socio).WithMany(p => p.ReservacionActividads)
                .HasForeignKey(d => d.SocioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReservacionActividad_Socio");
        });

        modelBuilder.Entity<ReservacionClase>(entity =>
        {
            entity.ToTable("ReservacionClase");

            entity.HasIndex(e => new { e.SocioId, e.FechaReservacion }, "IX_ReservacionClase_Socio").IsDescending(false, true);

            entity.HasIndex(e => new { e.SesionClaseId, e.SocioId }, "UQ_ReservacionClase_SocioSesion").IsUnique();

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Reservada");
            entity.Property(e => e.FechaAsistencia).HasPrecision(0);
            entity.Property(e => e.FechaCancelacion).HasPrecision(0);
            entity.Property(e => e.FechaReservacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Observaciones).HasMaxLength(250);

            entity.HasOne(d => d.SesionClase).WithMany(p => p.ReservacionClases)
                .HasForeignKey(d => d.SesionClaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReservacionClase_Sesion");

            entity.HasOne(d => d.Socio).WithMany(p => p.ReservacionClases)
                .HasForeignKey(d => d.SocioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReservacionClase_Socio");
        });

        modelBuilder.Entity<ReservacionServicio>(entity =>
        {
            entity.HasKey(e => e.ReservacionServicioId).HasName("PK__Reservac__4D0641F1362D37D4");

            entity.ToTable("ReservacionServicio");

            entity.HasIndex(e => new { e.FechaServicio, e.Estado }, "IX_ReservacionServicio_Fecha");

            entity.HasIndex(e => new { e.SocioId, e.FechaServicio }, "IX_ReservacionServicio_Socio");

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Reservada");
            entity.Property(e => e.FechaReservacion).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Observaciones).HasMaxLength(500);

            entity.HasOne(d => d.ContratacionServicio).WithMany(p => p.ReservacionServicios)
                .HasForeignKey(d => d.ContratacionServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReservacionServicio_Contratacion");

            entity.HasOne(d => d.Socio).WithMany(p => p.ReservacionServicios)
                .HasForeignKey(d => d.SocioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReservacionServicio_Socio");

            entity.HasOne(d => d.UsuarioResponsable).WithMany(p => p.ReservacionServicios)
                .HasForeignKey(d => d.UsuarioResponsableId)
                .HasConstraintName("FK_ReservacionServicio_Usuario");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.ToTable("Rol");

            entity.HasIndex(e => e.Nombre, "UQ_Rol_Nombre").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Nombre).HasMaxLength(80);
        });

        modelBuilder.Entity<RolPermiso>(entity =>
        {
            entity.HasKey(e => new { e.RolId, e.PermisoId });

            entity.ToTable("RolPermiso");

            entity.HasIndex(e => e.PermisoId, "IX_RolPermiso_Permiso");

            entity.Property(e => e.FechaAsignacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");

            entity.HasOne(d => d.Permiso).WithMany(p => p.RolPermisos)
                .HasForeignKey(d => d.PermisoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RolPermiso_Permiso");

            entity.HasOne(d => d.Rol).WithMany(p => p.RolPermisos)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RolPermiso_Rol");
        });

        modelBuilder.Entity<Rutina>(entity =>
        {
            entity.HasKey(e => e.RutinaId).HasName("PK__Rutina__E76E167AC6A93A2C");

            entity.ToTable("Rutina");

            entity.HasIndex(e => e.UsuarioCreadorId, "IX_Rutina_UsuarioCreador");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Nivel).HasMaxLength(30);
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.Objetivo).HasMaxLength(100);

            entity.HasOne(d => d.UsuarioCreador).WithMany(p => p.Rutinas)
                .HasForeignKey(d => d.UsuarioCreadorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rutina_Usuario");
        });

        modelBuilder.Entity<RutinaSocio>(entity =>
        {
            entity.HasKey(e => e.RutinaSocioId).HasName("PK__RutinaSo__961FA33FD30D5E10");

            entity.ToTable("RutinaSocio");

            entity.HasIndex(e => e.RutinaId, "IX_RutinaSocio_Rutina");

            entity.HasIndex(e => new { e.SocioId, e.Estado }, "IX_RutinaSocio_Socio");

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Activa");
            entity.Property(e => e.FechaAsignacion).HasDefaultValueSql("(CONVERT([date],getdate()))");
            entity.Property(e => e.Observaciones).HasMaxLength(500);

            entity.HasOne(d => d.Instructor).WithMany(p => p.RutinaSocios)
                .HasForeignKey(d => d.InstructorId)
                .HasConstraintName("FK_RutinaSocio_Instructor");

            entity.HasOne(d => d.Rutina).WithMany(p => p.RutinaSocios)
                .HasForeignKey(d => d.RutinaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RutinaSocio_Rutina");

            entity.HasOne(d => d.Socio).WithMany(p => p.RutinaSocios)
                .HasForeignKey(d => d.SocioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RutinaSocio_Socio");
        });

        modelBuilder.Entity<SaldoSocio>(entity =>
        {
            entity.ToTable("SaldoSocio");

            entity.HasIndex(e => new { e.SocioId, e.FechaMovimiento }, "IX_SaldoSocio_Socio").IsDescending(false, true);

            entity.Property(e => e.Concepto).HasMaxLength(250);
            entity.Property(e => e.FechaMovimiento)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TipoMovimiento)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Socio).WithMany(p => p.SaldoSocios)
                .HasForeignKey(d => d.SocioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaldoSocio_Socio");

            entity.HasOne(d => d.Usuario).WithMany(p => p.SaldoSocios)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaldoSocio_Usuario");

            entity.HasOne(d => d.Venta).WithMany(p => p.SaldoSocios)
                .HasForeignKey(d => d.VentaId)
                .HasConstraintName("FK_SaldoSocio_Venta");
        });

        modelBuilder.Entity<SeguimientoEjercicio>(entity =>
        {
            entity.HasKey(e => e.SeguimientoEjercicioId).HasName("PK__Seguimie__7D8A8FF389F846AC");

            entity.ToTable("SeguimientoEjercicio");

            entity.HasIndex(e => new { e.RutinaSocioId, e.FechaRealizacion }, "IX_SeguimientoEjercicio_RutinaSocio_Fecha");

            entity.Property(e => e.FechaRealizacion).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.PesoUtilizado).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.RepeticionesCompletadas).HasMaxLength(50);

            entity.HasOne(d => d.EjercicioRutina).WithMany(p => p.SeguimientoEjercicios)
                .HasForeignKey(d => d.EjercicioRutinaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeguimientoEjercicio_EjercicioRutina");

            entity.HasOne(d => d.RutinaSocio).WithMany(p => p.SeguimientoEjercicios)
                .HasForeignKey(d => d.RutinaSocioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeguimientoEjercicio_RutinaSocio");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.ServicioId).HasName("PK__Servicio__D5AEECC27F8EE4FB");

            entity.ToTable("Servicio");

            entity.HasIndex(e => e.CategoriaServicioId, "IX_Servicio_Categoria");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.CategoriaServicio).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.CategoriaServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Servicio_CategoriaServicio");
        });

        modelBuilder.Entity<ServicioSucursal>(entity =>
        {
            entity.HasKey(e => e.ServicioSucursalId).HasName("PK__Servicio__6544A5C015B25E1F");

            entity.ToTable("ServicioSucursal");

            entity.HasIndex(e => new { e.SucursalId, e.Disponible }, "IX_ServicioSucursal_Sucursal");

            entity.HasIndex(e => new { e.ServicioId, e.SucursalId }, "UQ_ServicioSucursal").IsUnique();

            entity.Property(e => e.Disponible).HasDefaultValue(true);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Servicio).WithMany(p => p.ServicioSucursals)
                .HasForeignKey(d => d.ServicioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServicioSucursal_Servicio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.ServicioSucursals)
                .HasForeignKey(d => d.SucursalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServicioSucursal_Sucursal");
        });

        modelBuilder.Entity<SesionClase>(entity =>
        {
            entity.ToTable("SesionClase");

            entity.HasIndex(e => new { e.Fecha, e.Estado, e.HoraInicio }, "IX_SesionClase_Fecha");

            entity.HasIndex(e => new { e.HorarioClaseId, e.Fecha }, "UQ_SesionClase_HorarioFecha").IsUnique();

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Programada");
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.HoraFin).HasPrecision(0);
            entity.Property(e => e.HoraInicio).HasPrecision(0);
            entity.Property(e => e.Observaciones).HasMaxLength(500);

            entity.HasOne(d => d.HorarioClase).WithMany(p => p.SesionClases)
                .HasForeignKey(d => d.HorarioClaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SesionClase_Horario");
        });

        modelBuilder.Entity<Socio>(entity =>
        {
            entity.ToTable("Socio");

            entity.HasIndex(e => e.Activo, "IX_Socio_Activo");

            entity.HasIndex(e => new { e.ApellidoPaterno, e.ApellidoMaterno, e.Nombre }, "IX_Socio_Nombre");

            entity.HasIndex(e => e.SucursalRegistroId, "IX_Socio_SucursalRegistro");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.ApellidoMaterno).HasMaxLength(100);
            entity.Property(e => e.ApellidoPaterno).HasMaxLength(100);
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Correo).HasMaxLength(150);
            entity.Property(e => e.Direccion).HasMaxLength(250);
            entity.Property(e => e.Estado).HasMaxLength(100);
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.FotografiaUrl).HasMaxLength(500);
            entity.Property(e => e.Municipio).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.NombreContactoEmergencia).HasMaxLength(150);
            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.Sexo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Telefono).HasMaxLength(20);
            entity.Property(e => e.TelefonoEmergencia).HasMaxLength(20);
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.SucursalRegistro).WithMany(p => p.Socios)
                .HasForeignKey(d => d.SucursalRegistroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Socio_Sucursal");
        });

        modelBuilder.Entity<Sucursal>(entity =>
        {
            entity.ToTable("Sucursal");

            entity.HasIndex(e => e.Activo, "IX_Sucursal_Activo");

            entity.HasIndex(e => e.Codigo, "UQ_Sucursal_Codigo").IsUnique();

            entity.HasIndex(e => e.EsPrincipal, "UX_Sucursal_Principal")
                .IsUnique()
                .HasFilter("([EsPrincipal]=(1))");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Correo).HasMaxLength(150);
            entity.Property(e => e.Direccion).HasMaxLength(250);
            entity.Property(e => e.Estado).HasMaxLength(100);
            entity.Property(e => e.FechaActualizacion).HasPrecision(0);
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Municipio).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.Telefono).HasMaxLength(20);
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<TipoClase>(entity =>
        {
            entity.ToTable("TipoClase");

            entity.HasIndex(e => e.Nombre, "UQ_TipoClase_Nombre").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<TipoNotificacion>(entity =>
        {
            entity.HasKey(e => e.TipoNotificacionId).HasName("PK__TipoNoti__BE05838DD5B66280");

            entity.ToTable("TipoNotificacion");

            entity.HasIndex(e => e.Codigo, "UQ_TipoNotificacion_Codigo").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Codigo).HasMaxLength(50);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<TraspasoInventario>(entity =>
        {
            entity.ToTable("TraspasoInventario");

            entity.HasIndex(e => e.Folio, "UQ_TraspasoInventario_Folio").IsUnique();

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Pendiente");
            entity.Property(e => e.FechaRecepcion).HasPrecision(0);
            entity.Property(e => e.FechaSolicitud)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Folio)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Observaciones).HasMaxLength(500);

            entity.HasOne(d => d.SucursalDestino).WithMany(p => p.TraspasoInventarioSucursalDestinos)
                .HasForeignKey(d => d.SucursalDestinoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Traspaso_Destino");

            entity.HasOne(d => d.SucursalOrigen).WithMany(p => p.TraspasoInventarioSucursalOrigens)
                .HasForeignKey(d => d.SucursalOrigenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Traspaso_Origen");

            entity.HasOne(d => d.Usuario).WithMany(p => p.TraspasoInventarios)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Traspaso_Usuario");
        });

        modelBuilder.Entity<UnidadMedidum>(entity =>
        {
            entity.HasKey(e => e.UnidadMedidaId);

            entity.HasIndex(e => e.Abreviatura, "UQ_UnidadMedida_Abreviatura").IsUnique();

            entity.HasIndex(e => e.Nombre, "UQ_UnidadMedida_Nombre").IsUnique();

            entity.Property(e => e.Abreviatura)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.ToTable("Usuario");

            entity.HasIndex(e => e.Activo, "IX_Usuario_Activo");

            entity.HasIndex(e => e.Correo, "UQ_Usuario_Correo").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.ApellidoMaterno).HasMaxLength(100);
            entity.Property(e => e.ApellidoPaterno).HasMaxLength(100);
            entity.Property(e => e.Correo).HasMaxLength(150);
            entity.Property(e => e.FechaActualizacion).HasPrecision(0);
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.FotografiaUrl).HasMaxLength(500);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.PasswordHash).HasMaxLength(500);
            entity.Property(e => e.Telefono).HasMaxLength(20);
            entity.Property(e => e.TipoAutenticacion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Local");
            entity.Property(e => e.UltimoAcceso).HasPrecision(0);
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<UsuarioRol>(entity =>
        {
            entity.HasKey(e => new { e.UsuarioId, e.RolId });

            entity.ToTable("UsuarioRol");

            entity.HasIndex(e => e.RolId, "IX_UsuarioRol_Rol");

            entity.Property(e => e.FechaAsignacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");

            entity.HasOne(d => d.Rol).WithMany(p => p.UsuarioRols)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioRol_Rol");

            entity.HasOne(d => d.Usuario).WithMany(p => p.UsuarioRols)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioRol_Usuario");
        });

        modelBuilder.Entity<UsuarioSucursal>(entity =>
        {
            entity.HasKey(e => new { e.UsuarioId, e.SucursalId });

            entity.ToTable("UsuarioSucursal");

            entity.HasIndex(e => new { e.SucursalId, e.Activo }, "IX_UsuarioSucursal_Sucursal");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaAsignacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.UsuarioSucursals)
                .HasForeignKey(d => d.SucursalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioSucursal_Sucursal");

            entity.HasOne(d => d.Usuario).WithMany(p => p.UsuarioSucursals)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioSucursal_Usuario");
        });

        modelBuilder.Entity<Ventum>(entity =>
        {
            entity.HasKey(e => e.VentaId);

            entity.HasIndex(e => new { e.Estado, e.FechaVenta }, "IX_Venta_Estado").IsDescending(false, true);

            entity.HasIndex(e => new { e.SocioId, e.FechaVenta }, "IX_Venta_Socio").IsDescending(false, true);

            entity.HasIndex(e => new { e.SucursalId, e.FechaVenta }, "IX_Venta_SucursalFecha").IsDescending(false, true);

            entity.HasIndex(e => e.Folio, "UQ_Venta_Folio").IsUnique();

            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Pendiente");
            entity.Property(e => e.FechaVenta)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Folio)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Impuesto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.Subtotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Caja).WithMany(p => p.Venta)
                .HasForeignKey(d => d.CajaId)
                .HasConstraintName("FK_Venta_Caja");

            entity.HasOne(d => d.CorteCaja).WithMany(p => p.Venta)
                .HasForeignKey(d => d.CorteCajaId)
                .HasConstraintName("FK_Venta_CorteCaja");

            entity.HasOne(d => d.Socio).WithMany(p => p.Venta)
                .HasForeignKey(d => d.SocioId)
                .HasConstraintName("FK_Venta_Socio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.Venta)
                .HasForeignKey(d => d.SucursalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Venta_Sucursal");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Venta)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Venta_Usuario");
        });

        modelBuilder.Entity<VisitaSocio>(entity =>
        {
            entity.ToTable("VisitaSocio");

            entity.HasIndex(e => new { e.SucursalId, e.SocioId }, "IX_VisitaSocio_Activas").HasFilter("([FechaSalida] IS NULL)");

            entity.HasIndex(e => new { e.SocioId, e.FechaEntrada }, "IX_VisitaSocio_Socio").IsDescending(false, true);

            entity.HasIndex(e => new { e.SucursalId, e.FechaEntrada }, "IX_VisitaSocio_Sucursal").IsDescending(false, true);

            entity.Property(e => e.FechaEntrada)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.FechaSalida).HasPrecision(0);
            entity.Property(e => e.Observaciones).HasMaxLength(250);
            entity.Property(e => e.TipoRegistro)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Entrada");

            entity.HasOne(d => d.AreaGimnasio).WithMany(p => p.VisitaSocios)
                .HasForeignKey(d => d.AreaGimnasioId)
                .HasConstraintName("FK_VisitaSocio_Area");

            entity.HasOne(d => d.MembresiaSocio).WithMany(p => p.VisitaSocios)
                .HasForeignKey(d => d.MembresiaSocioId)
                .HasConstraintName("FK_VisitaSocio_Membresia");

            entity.HasOne(d => d.Socio).WithMany(p => p.VisitaSocios)
                .HasForeignKey(d => d.SocioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VisitaSocio_Socio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.VisitaSocios)
                .HasForeignKey(d => d.SucursalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VisitaSocio_Sucursal");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
