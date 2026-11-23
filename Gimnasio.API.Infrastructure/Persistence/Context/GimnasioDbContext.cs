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

    public virtual DbSet<CatGimnasio> CatGimnasios { get; set; }

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

            entity.HasIndex(e => new { e.GimnasioId, e.MembresiaSocioId, e.FechaAcceso }, "IX_AccesoSocio_Gimnasio_Membresia").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.SocioId, e.FechaAcceso }, "IX_AccesoSocio_Gimnasio_Socio").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalId, e.FechaAcceso }, "IX_AccesoSocio_Gimnasio_Sucursal").IsDescending(false, false, true);

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
                .HasPrincipalKey(p => new { p.GimnasioId, p.MembresiaSocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.MembresiaSocioId })
                .HasConstraintName("FK_AccesoSocio_Membresia");

            entity.HasOne(d => d.Socio).WithMany(p => p.AccesoSocios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.SocioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccesoSocio_Socio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.AccesoSocios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccesoSocio_Sucursal");

            entity.HasOne(d => d.Usuario).WithMany(p => p.AccesoSocios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioId })
                .HasConstraintName("FK_AccesoSocio_Usuario");
        });

        modelBuilder.Entity<Actividad>(entity =>
        {
            entity.ToTable("Actividad");

            entity.HasIndex(e => new { e.GimnasioId, e.ActividadId }, "UQ_Actividad_Gimnasio_Actividad").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.TipoActividad).HasMaxLength(30);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.Actividads)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Actividad_Gimnasio");
        });

        modelBuilder.Entity<ActividadProgramadum>(entity =>
        {
            entity.HasKey(e => e.ActividadProgramadaId);

            entity.HasIndex(e => new { e.GimnasioId, e.ActividadId }, "IX_ActividadProgramada_Actividad");

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalId, e.FechaInicio }, "IX_ActividadProgramada_Sucursal_Fecha");

            entity.HasIndex(e => new { e.GimnasioId, e.ActividadProgramadaId }, "UQ_ActividadProgramada_Gimnasio_ActividadProgramada").IsUnique();

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Programada");
            entity.Property(e => e.Observaciones).HasMaxLength(500);

            entity.HasOne(d => d.Actividad).WithMany(p => p.ActividadProgramada)
                .HasPrincipalKey(p => new { p.GimnasioId, p.ActividadId })
                .HasForeignKey(d => new { d.GimnasioId, d.ActividadId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActividadProgramada_Actividad");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.ActividadProgramada)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActividadProgramada_Sucursal");

            entity.HasOne(d => d.Usuario).WithMany(p => p.ActividadProgramada)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioResponsableId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActividadProgramada_Usuario");
        });

        modelBuilder.Entity<AreaClase>(entity =>
        {
            entity.ToTable("AreaClase");

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalId, e.AreaClaseId }, "UQ_AreaClase_Gimnasio_Sucursal_Area").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalId, e.Nombre }, "UQ_AreaClase_Gimnasio_Sucursal_Nombre").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Sucursal).WithMany(p => p.AreaClases)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AreaClase_Sucursal");
        });

        modelBuilder.Entity<AreaGimnasio>(entity =>
        {
            entity.ToTable("AreaGimnasio");

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalId, e.Activo }, "IX_AreaGimnasio_Sucursal");

            entity.HasIndex(e => new { e.GimnasioId, e.AreaGimnasioId }, "UQ_AreaGimnasio_Gimnasio_Area").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.AreaGimnasios)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AreaGimnasio_Gimnasio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.AreaGimnasios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AreaGimnasio_Sucursal");
        });

        modelBuilder.Entity<AsistenciaActividad>(entity =>
        {
            entity.ToTable("AsistenciaActividad");

            entity.HasIndex(e => new { e.GimnasioId, e.ReservacionActividadId }, "UQ_AsistenciaActividad_Reservacion").IsUnique();

            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.ReservacionActividad).WithOne(p => p.AsistenciaActividad)
                .HasPrincipalKey<ReservacionActividad>(p => new { p.GimnasioId, p.ReservacionActividadId })
                .HasForeignKey<AsistenciaActividad>(d => new { d.GimnasioId, d.ReservacionActividadId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AsistenciaActividad_Reservacion");

            entity.HasOne(d => d.Usuario).WithMany(p => p.AsistenciaActividads)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioRegistroId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AsistenciaActividad_Usuario");
        });

        modelBuilder.Entity<AsistenciaClase>(entity =>
        {
            entity.ToTable("AsistenciaClase");

            entity.HasIndex(e => new { e.GimnasioId, e.ReservacionClaseId }, "UQ_AsistenciaClase_Reservacion").IsUnique();

            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Observaciones).HasMaxLength(250);

            entity.HasOne(d => d.ReservacionClase).WithOne(p => p.AsistenciaClase)
                .HasPrincipalKey<ReservacionClase>(p => new { p.GimnasioId, p.ReservacionClaseId })
                .HasForeignKey<AsistenciaClase>(d => new { d.GimnasioId, d.ReservacionClaseId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AsistenciaClase_Reservacion");

            entity.HasOne(d => d.Usuario).WithMany(p => p.AsistenciaClases)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioRegistroId })
                .HasConstraintName("FK_AsistenciaClase_Usuario");
        });

        modelBuilder.Entity<Caja>(entity =>
        {
            entity.ToTable("Caja");

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalId, e.Activo }, "IX_Caja_Sucursal");

            entity.HasIndex(e => new { e.GimnasioId, e.CajaId }, "UQ_Caja_Gimnasio_Caja").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.Cajas)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Caja_Gimnasio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.Cajas)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Caja_Sucursal");
        });

        modelBuilder.Entity<CatGimnasio>(entity =>
        {
            entity.HasKey(e => e.GimnasioId).HasName("PK_Gimnasio");

            entity.ToTable("CatGimnasio");

            entity.HasIndex(e => e.Codigo, "UQ_Gimnasio_Codigo").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FechaActualizacion).HasPrecision(0);
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        modelBuilder.Entity<CategoriaDocumento>(entity =>
        {
            entity.ToTable("CategoriaDocumento");

            entity.HasIndex(e => new { e.GimnasioId, e.CategoriaDocumentoId }, "UQ_CategoriaDocumento_Gimnasio_Categoria").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.Nombre }, "UQ_CategoriaDocumento_Gimnasio_Nombre").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.CategoriaDocumentos)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CategoriaDocumento_Gimnasio");
        });

        modelBuilder.Entity<CategoriaProducto>(entity =>
        {
            entity.ToTable("CategoriaProducto");

            entity.HasIndex(e => new { e.GimnasioId, e.CategoriaProductoId }, "UQ_CategoriaProducto_Gimnasio_Categoria").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.Nombre }, "UQ_CategoriaProducto_Nombre").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.CategoriaProductos)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CategoriaProducto_Gimnasio");
        });

        modelBuilder.Entity<CategoriaServicio>(entity =>
        {
            entity.ToTable("CategoriaServicio");

            entity.HasIndex(e => new { e.GimnasioId, e.CategoriaServicioId }, "UQ_CategoriaServicio_Gimnasio_Categoria").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.Nombre }, "UQ_CategoriaServicio_Gimnasio_Nombre").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.CategoriaServicios)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CategoriaServicio_Gimnasio");
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

            entity.HasIndex(e => new { e.GimnasioId, e.TipoClaseId, e.Activo }, "IX_Clase_Tipo");

            entity.HasIndex(e => new { e.GimnasioId, e.ClaseId }, "UQ_Clase_Gimnasio_Clase").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Nombre).HasMaxLength(150);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.Clases)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Clase_Gimnasio");

            entity.HasOne(d => d.TipoClase).WithMany(p => p.Clases)
                .HasForeignKey(d => d.TipoClaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Clase_TipoClase");
        });

        modelBuilder.Entity<CompraProveedor>(entity =>
        {
            entity.ToTable("CompraProveedor");

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalId, e.FechaCompra }, "IX_CompraProveedor_Fecha").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.ProveedorId, e.FechaCompra }, "IX_CompraProveedor_Proveedor").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.Folio }, "UQ_CompraProveedor_Folio").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.CompraProveedorId }, "UQ_CompraProveedor_Gimnasio_Compra").IsUnique();

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

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.CompraProveedors)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompraProveedor_Gimnasio");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.CompraProveedors)
                .HasPrincipalKey(p => new { p.GimnasioId, p.ProveedorId })
                .HasForeignKey(d => new { d.GimnasioId, d.ProveedorId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompraProveedor_Proveedor");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.CompraProveedors)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompraProveedor_Sucursal");

            entity.HasOne(d => d.Usuario).WithMany(p => p.CompraProveedors)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CompraProveedor_Usuario");
        });

        modelBuilder.Entity<Comunicado>(entity =>
        {
            entity.ToTable("Comunicado");

            entity.HasIndex(e => new { e.GimnasioId, e.Estado, e.FechaPublicacion }, "IX_Comunicado_Estado_Fecha").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.ComunicadoId }, "UQ_Comunicado_Gimnasio_Comunicado").IsUnique();

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Borrador");
            entity.Property(e => e.PublicoObjetivo)
                .HasMaxLength(20)
                .HasDefaultValue("Todos");
            entity.Property(e => e.Titulo).HasMaxLength(200);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.Comunicados)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comunicado_Gimnasio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.Comunicados)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId })
                .HasConstraintName("FK_Comunicado_Sucursal");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Comunicados)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioCreadorId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Comunicado_Usuario");
        });

        modelBuilder.Entity<ComunicadoLectura>(entity =>
        {
            entity.ToTable("ComunicadoLectura");

            entity.HasIndex(e => new { e.GimnasioId, e.ComunicadoId, e.SocioId }, "UX_ComunicadoLectura_Socio")
                .IsUnique()
                .HasFilter("([SocioId] IS NOT NULL)");

            entity.HasIndex(e => new { e.GimnasioId, e.ComunicadoId, e.UsuarioId }, "UX_ComunicadoLectura_Usuario")
                .IsUnique()
                .HasFilter("([UsuarioId] IS NOT NULL)");

            entity.Property(e => e.FechaLectura).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.Comunicado).WithMany(p => p.ComunicadoLecturas)
                .HasPrincipalKey(p => new { p.GimnasioId, p.ComunicadoId })
                .HasForeignKey(d => new { d.GimnasioId, d.ComunicadoId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ComunicadoLectura_Comunicado");

            entity.HasOne(d => d.Socio).WithMany(p => p.ComunicadoLecturas)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.SocioId })
                .HasConstraintName("FK_ComunicadoLectura_Socio");

            entity.HasOne(d => d.Usuario).WithMany(p => p.ComunicadoLecturas)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioId })
                .HasConstraintName("FK_ComunicadoLectura_Usuario");
        });

        modelBuilder.Entity<ConfiguracionGeneral>(entity =>
        {
            entity.HasKey(e => new { e.GimnasioId, e.ConfiguracionGeneralId });

            entity.ToTable("ConfiguracionGeneral");

            entity.Property(e => e.ConfiguracionGeneralId).HasDefaultValue(1);
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

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.ConfiguracionGenerals)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConfiguracionGeneral_Gimnasio");
        });

        modelBuilder.Entity<ConfiguracionMembresium>(entity =>
        {
            entity.HasKey(e => e.ConfiguracionMembresiaId);

            entity.HasIndex(e => e.GimnasioId, "UQ_ConfiguracionMembresia_Gimnasio").IsUnique();

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

            entity.HasOne(d => d.Gimnasio).WithOne(p => p.ConfiguracionMembresium)
                .HasForeignKey<ConfiguracionMembresium>(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConfiguracionMembresia_Gimnasio");
        });

        modelBuilder.Entity<ContratacionServicio>(entity =>
        {
            entity.ToTable("ContratacionServicio");

            entity.HasIndex(e => new { e.GimnasioId, e.ServicioId }, "IX_ContratacionServicio_Servicio");

            entity.HasIndex(e => new { e.GimnasioId, e.SocioId, e.Estado }, "IX_ContratacionServicio_Socio");

            entity.HasIndex(e => new { e.GimnasioId, e.ContratacionServicioId }, "UQ_ContratacionServicio_Gimnasio_Contratacion").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.ContratacionServicioId, e.SocioId }, "UQ_ContratacionServicio_Gimnasio_Contratacion_Socio").IsUnique();

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Activa");
            entity.Property(e => e.FechaContratacion).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.PrecioAplicado).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Servicio).WithMany(p => p.ContratacionServicios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.ServicioId })
                .HasForeignKey(d => new { d.GimnasioId, d.ServicioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContratacionServicio_Servicio");

            entity.HasOne(d => d.Socio).WithMany(p => p.ContratacionServicios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.SocioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContratacionServicio_Socio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.ContratacionServicios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContratacionServicio_Sucursal");

            entity.HasOne(d => d.Usuario).WithMany(p => p.ContratacionServicios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioRegistroId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContratacionServicio_Usuario");

            entity.HasOne(d => d.Ventum).WithMany(p => p.ContratacionServicios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.VentaId })
                .HasForeignKey(d => new { d.GimnasioId, d.VentaId })
                .HasConstraintName("FK_ContratacionServicio_Venta");
        });

        modelBuilder.Entity<CorteCaja>(entity =>
        {
            entity.ToTable("CorteCaja");

            entity.HasIndex(e => new { e.GimnasioId, e.FechaApertura }, "IX_CorteCaja_Gimnasio_Fecha").IsDescending(false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.CorteCajaId }, "UQ_CorteCaja_Gimnasio_Corte").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.CajaId }, "UX_CorteCaja_Abierto")
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

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.CorteCajas)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CorteCaja_Gimnasio");

            entity.HasOne(d => d.Caja).WithOne(p => p.CorteCaja)
                .HasPrincipalKey<Caja>(p => new { p.GimnasioId, p.CajaId })
                .HasForeignKey<CorteCaja>(d => new { d.GimnasioId, d.CajaId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CorteCaja_Caja");

            entity.HasOne(d => d.Usuario).WithMany(p => p.CorteCajaUsuarios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioAperturaId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CorteCaja_UsuarioApertura");

            entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.CorteCajaUsuarioNavigations)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioCierreId })
                .HasConstraintName("FK_CorteCaja_UsuarioCierre");
        });

        modelBuilder.Entity<DetalleCompraProveedor>(entity =>
        {
            entity.ToTable("DetalleCompraProveedor");

            entity.HasIndex(e => new { e.GimnasioId, e.CompraProveedorId }, "IX_DetalleCompra_Compra");

            entity.HasIndex(e => new { e.GimnasioId, e.ProductoId }, "IX_DetalleCompra_Producto");

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Descuento).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Impuesto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioUnitario).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.DetalleCompraProveedors)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleCompra_Gimnasio");

            entity.HasOne(d => d.CompraProveedor).WithMany(p => p.DetalleCompraProveedors)
                .HasPrincipalKey(p => new { p.GimnasioId, p.CompraProveedorId })
                .HasForeignKey(d => new { d.GimnasioId, d.CompraProveedorId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleCompra_Compra");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetalleCompraProveedors)
                .HasPrincipalKey(p => new { p.GimnasioId, p.ProductoId })
                .HasForeignKey(d => new { d.GimnasioId, d.ProductoId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleCompra_Producto");
        });

        modelBuilder.Entity<DetalleTraspasoInventario>(entity =>
        {
            entity.ToTable("DetalleTraspasoInventario");

            entity.HasIndex(e => new { e.GimnasioId, e.ProductoId }, "IX_DetalleTraspaso_Producto");

            entity.HasIndex(e => new { e.GimnasioId, e.TraspasoInventarioId, e.ProductoId }, "UQ_DetalleTraspaso_Producto").IsUnique();

            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.DetalleTraspasoInventarios)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleTraspaso_Gimnasio");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetalleTraspasoInventarios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.ProductoId })
                .HasForeignKey(d => new { d.GimnasioId, d.ProductoId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleTraspaso_Producto");

            entity.HasOne(d => d.TraspasoInventario).WithMany(p => p.DetalleTraspasoInventarios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.TraspasoInventarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.TraspasoInventarioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleTraspaso_Traspaso");
        });

        modelBuilder.Entity<DetalleVentum>(entity =>
        {
            entity.HasKey(e => e.DetalleVentaId);

            entity.HasIndex(e => new { e.GimnasioId, e.MembresiaSocioId }, "IX_DetalleVenta_Membresia");

            entity.HasIndex(e => new { e.GimnasioId, e.VentaId }, "IX_DetalleVenta_Venta");

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
                .HasPrincipalKey(p => new { p.GimnasioId, p.MembresiaSocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.MembresiaSocioId })
                .HasConstraintName("FK_DetalleVenta_Membresia");

            entity.HasOne(d => d.PlanMembresium).WithMany(p => p.DetalleVenta)
                .HasPrincipalKey(p => new { p.GimnasioId, p.PlanMembresiaId })
                .HasForeignKey(d => new { d.GimnasioId, d.PlanMembresiaId })
                .HasConstraintName("FK_DetalleVenta_Plan");

            entity.HasOne(d => d.Ventum).WithMany(p => p.DetalleVenta)
                .HasPrincipalKey(p => new { p.GimnasioId, p.VentaId })
                .HasForeignKey(d => new { d.GimnasioId, d.VentaId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetalleVenta_Venta");
        });

        modelBuilder.Entity<DiaRutina>(entity =>
        {
            entity.ToTable("DiaRutina");

            entity.HasIndex(e => new { e.GimnasioId, e.RutinaId }, "IX_DiaRutina_Rutina");

            entity.HasIndex(e => new { e.GimnasioId, e.DiaRutinaId }, "UQ_DiaRutina_Gimnasio_DiaRutina").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.RutinaId, e.Orden }, "UQ_DiaRutina_Rutina_Orden").IsUnique();

            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.DiaSemana).WithMany(p => p.DiaRutinas)
                .HasForeignKey(d => d.DiaSemanaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiaRutina_DiaSemana");

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.DiaRutinas)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DiaRutina_Gimnasio");

            entity.HasOne(d => d.Rutina).WithMany(p => p.DiaRutinas)
                .HasPrincipalKey(p => new { p.GimnasioId, p.RutinaId })
                .HasForeignKey(d => new { d.GimnasioId, d.RutinaId })
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
            entity.ToTable("Documento");

            entity.HasIndex(e => new { e.GimnasioId, e.CategoriaDocumentoId }, "IX_Documento_Categoria");

            entity.HasIndex(e => new { e.GimnasioId, e.SocioId, e.FechaCarga }, "IX_Documento_Socio").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.UsuarioId, e.FechaCarga }, "IX_Documento_Usuario").IsDescending(false, false, true);

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

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.Documentos)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Documento_Gimnasio");

            entity.HasOne(d => d.CategoriaDocumento).WithMany(p => p.Documentos)
                .HasPrincipalKey(p => new { p.GimnasioId, p.CategoriaDocumentoId })
                .HasForeignKey(d => new { d.GimnasioId, d.CategoriaDocumentoId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Documento_Categoria");

            entity.HasOne(d => d.Socio).WithMany(p => p.Documentos)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.SocioId })
                .HasConstraintName("FK_Documento_Socio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.Documentos)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId })
                .HasConstraintName("FK_Documento_Sucursal");

            entity.HasOne(d => d.Usuario).WithMany(p => p.DocumentoUsuarios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioCargaId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Documento_UsuarioCarga");

            entity.HasOne(d => d.UsuarioNavigation).WithMany(p => p.DocumentoUsuarioNavigations)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioId })
                .HasConstraintName("FK_Documento_Usuario");
        });

        modelBuilder.Entity<Ejercicio>(entity =>
        {
            entity.ToTable("Ejercicio");

            entity.HasIndex(e => new { e.GimnasioId, e.GrupoMuscularId }, "IX_Ejercicio_GrupoMuscular");

            entity.HasIndex(e => new { e.GimnasioId, e.EjercicioId }, "UQ_Ejercicio_Gimnasio_Ejercicio").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.EquipoNecesario).HasMaxLength(200);
            entity.Property(e => e.ImagenUrl).HasMaxLength(500);
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.TipoEjercicio).HasMaxLength(30);
            entity.Property(e => e.VideoUrl).HasMaxLength(500);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.Ejercicios)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ejercicio_Gimnasio");

            entity.HasOne(d => d.GrupoMuscular).WithMany(p => p.Ejercicios)
                .HasForeignKey(d => d.GrupoMuscularId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ejercicio_GrupoMuscular");
        });

        modelBuilder.Entity<EjercicioRutina>(entity =>
        {
            entity.ToTable("EjercicioRutina");

            entity.HasIndex(e => new { e.GimnasioId, e.EjercicioId }, "IX_EjercicioRutina_Ejercicio");

            entity.HasIndex(e => new { e.GimnasioId, e.DiaRutinaId, e.Orden }, "UQ_EjercicioRutina_Dia_Orden").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.EjercicioRutinaId }, "UQ_EjercicioRutina_Gimnasio_EjercicioRutina").IsUnique();

            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.Peso).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Repeticiones).HasMaxLength(50);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.EjercicioRutinas)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EjercicioRutina_Gimnasio");

            entity.HasOne(d => d.DiaRutina).WithMany(p => p.EjercicioRutinas)
                .HasPrincipalKey(p => new { p.GimnasioId, p.DiaRutinaId })
                .HasForeignKey(d => new { d.GimnasioId, d.DiaRutinaId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EjercicioRutina_DiaRutina");

            entity.HasOne(d => d.Ejercicio).WithMany(p => p.EjercicioRutinas)
                .HasPrincipalKey(p => new { p.GimnasioId, p.EjercicioId })
                .HasForeignKey(d => new { d.GimnasioId, d.EjercicioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EjercicioRutina_Ejercicio");
        });

        modelBuilder.Entity<EvaluacionFisica>(entity =>
        {
            entity.ToTable("EvaluacionFisica");

            entity.HasIndex(e => new { e.GimnasioId, e.SocioId, e.FechaEvaluacion }, "IX_EvaluacionFisica_Socio_Fecha").IsDescending(false, false, true);

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

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.EvaluacionFisicas)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EvaluacionFisica_Gimnasio");

            entity.HasOne(d => d.Instructor).WithMany(p => p.EvaluacionFisicas)
                .HasPrincipalKey(p => new { p.GimnasioId, p.InstructorId })
                .HasForeignKey(d => new { d.GimnasioId, d.InstructorId })
                .HasConstraintName("FK_EvaluacionFisica_Instructor");

            entity.HasOne(d => d.Socio).WithMany(p => p.EvaluacionFisicas)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.SocioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EvaluacionFisica_Socio");

            entity.HasOne(d => d.Usuario).WithMany(p => p.EvaluacionFisicas)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioRegistroId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EvaluacionFisica_Usuario");
        });

        modelBuilder.Entity<ExcepcionHorarioSucursal>(entity =>
        {
            entity.ToTable("ExcepcionHorarioSucursal");

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalId, e.Fecha }, "IX_ExcepcionHorarioSucursal_Gimnasio_Sucursal_Fecha");

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalId, e.Fecha }, "UQ_ExcepcionHorarioSucursal").IsUnique();

            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.HoraApertura).HasPrecision(0);
            entity.Property(e => e.HoraCierre).HasPrecision(0);
            entity.Property(e => e.Motivo).HasMaxLength(250);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.ExcepcionHorarioSucursals)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExcepcionHorarioSucursal_Gimnasio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.ExcepcionHorarioSucursals)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExcepcionHorarioSucursal_Sucursal");
        });

        modelBuilder.Entity<GrupoMuscular>(entity =>
        {
            entity.ToTable("GrupoMuscular");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<HistorialMembresium>(entity =>
        {
            entity.HasKey(e => e.HistorialMembresiaId);

            entity.HasIndex(e => new { e.GimnasioId, e.MembresiaSocioId, e.FechaEvento }, "IX_HistorialMembresia_Gimnasio_Membresia").IsDescending(false, false, true);

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
                .HasPrincipalKey(p => new { p.GimnasioId, p.MembresiaSocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.MembresiaSocioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistorialMembresia_Membresia");

            entity.HasOne(d => d.Usuario).WithMany(p => p.HistorialMembresia)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioId })
                .HasConstraintName("FK_HistorialMembresia_Usuario");
        });

        modelBuilder.Entity<HistorialNotificacion>(entity =>
        {
            entity.ToTable("HistorialNotificacion");

            entity.HasIndex(e => new { e.GimnasioId, e.NotificacionId, e.FechaIntento }, "IX_HistorialNotificacion_Notificacion").IsDescending(false, false, true);

            entity.Property(e => e.Detalle).HasMaxLength(1000);
            entity.Property(e => e.FechaIntento).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Resultado).HasMaxLength(20);

            entity.HasOne(d => d.Notificacion).WithMany(p => p.HistorialNotificacions)
                .HasPrincipalKey(p => new { p.GimnasioId, p.NotificacionId })
                .HasForeignKey(d => new { d.GimnasioId, d.NotificacionId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistorialNotificacion_Notificacion");
        });

        modelBuilder.Entity<HistorialObjetivoFisico>(entity =>
        {
            entity.ToTable("HistorialObjetivoFisico");

            entity.HasIndex(e => new { e.GimnasioId, e.ObjetivoFisicoId, e.FechaRegistro }, "IX_HistorialObjetivoFisico_Objetivo_Fecha").IsDescending(false, false, true);

            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.ValorRegistrado).HasColumnType("decimal(8, 2)");

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.HistorialObjetivoFisicos)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistorialObjetivoFisico_Gimnasio");

            entity.HasOne(d => d.ObjetivoFisico).WithMany(p => p.HistorialObjetivoFisicos)
                .HasPrincipalKey(p => new { p.GimnasioId, p.ObjetivoFisicoId })
                .HasForeignKey(d => new { d.GimnasioId, d.ObjetivoFisicoId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistorialObjetivoFisico_Objetivo");
        });

        modelBuilder.Entity<HorarioClase>(entity =>
        {
            entity.ToTable("HorarioClase");

            entity.HasIndex(e => new { e.GimnasioId, e.InstructorId, e.DiaSemanaId, e.HoraInicio }, "IX_HorarioClase_Instructor");

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalId, e.DiaSemanaId, e.HoraInicio, e.Activo }, "IX_HorarioClase_SucursalDia");

            entity.HasIndex(e => new { e.GimnasioId, e.HorarioClaseId }, "UQ_HorarioClase_Gimnasio_Horario").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.HoraFin).HasPrecision(0);
            entity.Property(e => e.HoraInicio).HasPrecision(0);

            entity.HasOne(d => d.DiaSemana).WithMany(p => p.HorarioClases)
                .HasForeignKey(d => d.DiaSemanaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HorarioClase_Dia");

            entity.HasOne(d => d.Clase).WithMany(p => p.HorarioClases)
                .HasPrincipalKey(p => new { p.GimnasioId, p.ClaseId })
                .HasForeignKey(d => new { d.GimnasioId, d.ClaseId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HorarioClase_Clase");

            entity.HasOne(d => d.Instructor).WithMany(p => p.HorarioClases)
                .HasPrincipalKey(p => new { p.GimnasioId, p.InstructorId })
                .HasForeignKey(d => new { d.GimnasioId, d.InstructorId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HorarioClase_Instructor");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.HorarioClases)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HorarioClase_Sucursal");

            entity.HasOne(d => d.AreaClase).WithMany(p => p.HorarioClases)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId, p.AreaClaseId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId, d.AreaClaseId })
                .HasConstraintName("FK_HorarioClase_Area");
        });

        modelBuilder.Entity<HorarioSucursal>(entity =>
        {
            entity.ToTable("HorarioSucursal");

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalId }, "IX_HorarioSucursal_Gimnasio_Sucursal");

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalId, e.DiaSemanaId }, "UQ_HorarioSucursal").IsUnique();

            entity.Property(e => e.HoraApertura).HasPrecision(0);
            entity.Property(e => e.HoraCierre).HasPrecision(0);

            entity.HasOne(d => d.DiaSemana).WithMany(p => p.HorarioSucursals)
                .HasForeignKey(d => d.DiaSemanaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HorarioSucursal_Dia");

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.HorarioSucursals)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HorarioSucursal_Gimnasio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.HorarioSucursals)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HorarioSucursal_Sucursal");
        });

        modelBuilder.Entity<IncidenciaOperativa>(entity =>
        {
            entity.ToTable("IncidenciaOperativa");

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalId, e.Estado, e.FechaReporte }, "IX_Incidencia_Sucursal").IsDescending(false, false, false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.UsuarioId }, "IX_Incidencia_Usuario");

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

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.IncidenciaOperativas)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Incidencia_Gimnasio");

            entity.HasOne(d => d.AreaGimnasio).WithMany(p => p.IncidenciaOperativas)
                .HasPrincipalKey(p => new { p.GimnasioId, p.AreaGimnasioId })
                .HasForeignKey(d => new { d.GimnasioId, d.AreaGimnasioId })
                .HasConstraintName("FK_Incidencia_Area");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.IncidenciaOperativas)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Incidencia_Sucursal");

            entity.HasOne(d => d.Usuario).WithMany(p => p.IncidenciaOperativas)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioId })
                .HasConstraintName("FK_Incidencia_Usuario");
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.ToTable("Instructor");

            entity.HasIndex(e => new { e.GimnasioId, e.ApellidoPaterno, e.Nombre }, "IX_Instructor_Nombre");

            entity.HasIndex(e => new { e.GimnasioId, e.InstructorId }, "UQ_Instructor_Gimnasio_Instructor").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.UsuarioId }, "UX_Instructor_Usuario")
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

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.Instructors)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Instructor_Gimnasio");

            entity.HasOne(d => d.Usuario).WithOne(p => p.Instructor)
                .HasPrincipalKey<Usuario>(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey<Instructor>(d => new { d.GimnasioId, d.UsuarioId })
                .HasConstraintName("FK_Instructor_Usuario");
        });

        modelBuilder.Entity<InventarioSucursal>(entity =>
        {
            entity.ToTable("InventarioSucursal");

            entity.HasIndex(e => new { e.GimnasioId, e.ProductoId }, "IX_InventarioSucursal_Producto");

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalId, e.ProductoId }, "UQ_InventarioSucursal").IsUnique();

            entity.Property(e => e.Existencia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaActualizacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.StockReservado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Version)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.InventarioSucursals)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventarioSucursal_Gimnasio");

            entity.HasOne(d => d.Producto).WithMany(p => p.InventarioSucursals)
                .HasPrincipalKey(p => new { p.GimnasioId, p.ProductoId })
                .HasForeignKey(d => new { d.GimnasioId, d.ProductoId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventarioSucursal_Producto");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.InventarioSucursals)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InventarioSucursal_Sucursal");
        });

        modelBuilder.Entity<ListaEsperaClase>(entity =>
        {
            entity.ToTable("ListaEsperaClase");

            entity.HasIndex(e => new { e.GimnasioId, e.SesionClaseId, e.Estado, e.FechaRegistro }, "IX_ListaEspera_Orden");

            entity.HasIndex(e => new { e.GimnasioId, e.SesionClaseId, e.SocioId }, "UQ_ListaEspera_SocioSesion").IsUnique();

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("EnEspera");
            entity.Property(e => e.FechaNotificacion).HasPrecision(0);
            entity.Property(e => e.FechaRegistro)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");

            entity.HasOne(d => d.SesionClase).WithMany(p => p.ListaEsperaClases)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SesionClaseId })
                .HasForeignKey(d => new { d.GimnasioId, d.SesionClaseId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ListaEspera_Sesion");

            entity.HasOne(d => d.Socio).WithMany(p => p.ListaEsperaClases)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.SocioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ListaEspera_Socio");
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.ToTable("Marca");

            entity.HasIndex(e => new { e.GimnasioId, e.MarcaId }, "UQ_Marca_Gimnasio_Marca").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.Nombre }, "UQ_Marca_Nombre").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.Marcas)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Marca_Gimnasio");
        });

        modelBuilder.Entity<MembresiaSocio>(entity =>
        {
            entity.ToTable("MembresiaSocio");

            entity.HasIndex(e => new { e.GimnasioId, e.MembresiaAnteriorId }, "IX_MembresiaSocio_Anterior").HasFilter("([MembresiaAnteriorId] IS NOT NULL)");

            entity.HasIndex(e => new { e.GimnasioId, e.Estado, e.FechaInicio, e.FechaFin }, "IX_MembresiaSocio_Gimnasio_Estado");

            entity.HasIndex(e => new { e.GimnasioId, e.PlanMembresiaId }, "IX_MembresiaSocio_Gimnasio_Plan");

            entity.HasIndex(e => new { e.GimnasioId, e.SocioId, e.FechaInicio }, "IX_MembresiaSocio_Gimnasio_Socio").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalCompraId }, "IX_MembresiaSocio_Gimnasio_SucursalCompra");

            entity.HasIndex(e => new { e.GimnasioId, e.MembresiaSocioId }, "UQ_MembresiaSocio_Gimnasio_Membresia").IsUnique();

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

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.MembresiaSocios)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MembresiaSocio_Gimnasio");

            entity.HasOne(d => d.MembresiaSocioNavigation).WithMany(p => p.InverseMembresiaSocioNavigation)
                .HasPrincipalKey(p => new { p.GimnasioId, p.MembresiaSocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.MembresiaAnteriorId })
                .HasConstraintName("FK_MembresiaSocio_Anterior");

            entity.HasOne(d => d.PlanMembresium).WithMany(p => p.MembresiaSocios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.PlanMembresiaId })
                .HasForeignKey(d => new { d.GimnasioId, d.PlanMembresiaId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MembresiaSocio_Plan");

            entity.HasOne(d => d.Socio).WithMany(p => p.MembresiaSocios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.SocioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MembresiaSocio_Socio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.MembresiaSocios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalCompraId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MembresiaSocio_Sucursal");
        });

        modelBuilder.Entity<MembresiaSucursal>(entity =>
        {
            entity.ToTable("MembresiaSucursal");

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalId, e.Activo }, "IX_MembresiaSucursal_Gimnasio_Sucursal");

            entity.HasIndex(e => new { e.MembresiaSocioId, e.SucursalId }, "UQ_MembresiaSucursal").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaAsignacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");

            entity.HasOne(d => d.MembresiaSocio).WithMany(p => p.MembresiaSucursals)
                .HasPrincipalKey(p => new { p.GimnasioId, p.MembresiaSocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.MembresiaSocioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MembresiaSucursal_Membresia");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.MembresiaSucursals)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId })
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

            entity.HasIndex(e => new { e.GimnasioId, e.CorteCajaId, e.FechaMovimiento }, "IX_MovimientoCaja_Corte").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.UsuarioId }, "IX_MovimientoCaja_Usuario");

            entity.Property(e => e.Concepto).HasMaxLength(150);
            entity.Property(e => e.FechaMovimiento)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Observaciones).HasMaxLength(250);
            entity.Property(e => e.TipoMovimiento)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.MovimientoCajas)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientoCaja_Gimnasio");

            entity.HasOne(d => d.CorteCaja).WithMany(p => p.MovimientoCajas)
                .HasPrincipalKey(p => new { p.GimnasioId, p.CorteCajaId })
                .HasForeignKey(d => new { d.GimnasioId, d.CorteCajaId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientoCaja_Corte");

            entity.HasOne(d => d.Usuario).WithMany(p => p.MovimientoCajas)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientoCaja_Usuario");
        });

        modelBuilder.Entity<MovimientoInventario>(entity =>
        {
            entity.ToTable("MovimientoInventario");

            entity.HasIndex(e => new { e.GimnasioId, e.CompraProveedorId }, "IX_MovimientoInventario_Compra");

            entity.HasIndex(e => new { e.GimnasioId, e.ProductoId, e.SucursalId, e.FechaMovimiento }, "IX_MovimientoInventario_Producto").IsDescending(false, false, false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.VentaId }, "IX_MovimientoInventario_Venta");

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

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.MovimientoInventarios)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientoInventario_Gimnasio");

            entity.HasOne(d => d.CompraProveedor).WithMany(p => p.MovimientoInventarios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.CompraProveedorId })
                .HasForeignKey(d => new { d.GimnasioId, d.CompraProveedorId })
                .HasConstraintName("FK_MovimientoInventario_Compra");

            entity.HasOne(d => d.Producto).WithMany(p => p.MovimientoInventarios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.ProductoId })
                .HasForeignKey(d => new { d.GimnasioId, d.ProductoId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientoInventario_Producto");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.MovimientoInventarios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientoInventario_Sucursal");

            entity.HasOne(d => d.Usuario).WithMany(p => p.MovimientoInventarios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientoInventario_Usuario");

            entity.HasOne(d => d.Ventum).WithMany(p => p.MovimientoInventarios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.VentaId })
                .HasForeignKey(d => new { d.GimnasioId, d.VentaId })
                .HasConstraintName("FK_MovimientoInventario_Venta");
        });

        modelBuilder.Entity<Notificacion>(entity =>
        {
            entity.ToTable("Notificacion");

            entity.HasIndex(e => new { e.GimnasioId, e.Estado, e.FechaProgramada }, "IX_Notificacion_Estado_Fecha");

            entity.HasIndex(e => new { e.GimnasioId, e.SocioId, e.FechaEnvio }, "IX_Notificacion_Socio_Fecha").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.NotificacionId }, "UQ_Notificacion_Gimnasio_Notificacion").IsUnique();

            entity.Property(e => e.Canal).HasMaxLength(20);
            entity.Property(e => e.ErrorEnvio).HasMaxLength(1000);
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Pendiente");
            entity.Property(e => e.Titulo).HasMaxLength(200);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.Notificacions)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notificacion_Gimnasio");

            entity.HasOne(d => d.TipoNotificacion).WithMany(p => p.Notificacions)
                .HasForeignKey(d => d.TipoNotificacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notificacion_Tipo");

            entity.HasOne(d => d.PlantillaNotificacion).WithMany(p => p.Notificacions)
                .HasPrincipalKey(p => new { p.GimnasioId, p.PlantillaNotificacionId })
                .HasForeignKey(d => new { d.GimnasioId, d.PlantillaNotificacionId })
                .HasConstraintName("FK_Notificacion_Plantilla");

            entity.HasOne(d => d.Socio).WithMany(p => p.Notificacions)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.SocioId })
                .HasConstraintName("FK_Notificacion_Socio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.Notificacions)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId })
                .HasConstraintName("FK_Notificacion_Sucursal");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Notificacions)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioId })
                .HasConstraintName("FK_Notificacion_Usuario");
        });

        modelBuilder.Entity<NotificacionLectura>(entity =>
        {
            entity.ToTable("NotificacionLectura");

            entity.HasIndex(e => new { e.GimnasioId, e.NotificacionId, e.SocioId }, "UX_NotificacionLectura_Socio")
                .IsUnique()
                .HasFilter("([SocioId] IS NOT NULL)");

            entity.HasIndex(e => new { e.GimnasioId, e.NotificacionId, e.UsuarioId }, "UX_NotificacionLectura_Usuario")
                .IsUnique()
                .HasFilter("([UsuarioId] IS NOT NULL)");

            entity.Property(e => e.FechaLectura).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.Notificacion).WithMany(p => p.NotificacionLecturas)
                .HasPrincipalKey(p => new { p.GimnasioId, p.NotificacionId })
                .HasForeignKey(d => new { d.GimnasioId, d.NotificacionId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NotificacionLectura_Notificacion");

            entity.HasOne(d => d.Socio).WithMany(p => p.NotificacionLecturas)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.SocioId })
                .HasConstraintName("FK_NotificacionLectura_Socio");

            entity.HasOne(d => d.Usuario).WithMany(p => p.NotificacionLecturas)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioId })
                .HasConstraintName("FK_NotificacionLectura_Usuario");
        });

        modelBuilder.Entity<ObjetivoFisico>(entity =>
        {
            entity.ToTable("ObjetivoFisico");

            entity.HasIndex(e => new { e.GimnasioId, e.SocioId, e.Estado }, "IX_ObjetivoFisico_Socio_Estado");

            entity.HasIndex(e => new { e.GimnasioId, e.ObjetivoFisicoId }, "UQ_ObjetivoFisico_Gimnasio_Objetivo").IsUnique();

            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("EnProceso");
            entity.Property(e => e.FechaInicio).HasDefaultValueSql("(CONVERT([date],getdate()))");
            entity.Property(e => e.TipoObjetivo).HasMaxLength(50);
            entity.Property(e => e.UnidadMedida).HasMaxLength(30);
            entity.Property(e => e.ValorInicial).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ValorObjetivo).HasColumnType("decimal(8, 2)");

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.ObjetivoFisicos)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ObjetivoFisico_Gimnasio");

            entity.HasOne(d => d.Socio).WithMany(p => p.ObjetivoFisicos)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.SocioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ObjetivoFisico_Socio");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.ToTable("Pago");

            entity.HasIndex(e => new { e.GimnasioId, e.CorteCajaId, e.FechaPago }, "IX_Pago_CorteCaja").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.UsuarioId }, "IX_Pago_Usuario");

            entity.HasIndex(e => new { e.GimnasioId, e.VentaId, e.FechaPago }, "IX_Pago_Venta").IsDescending(false, false, true);

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

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pago_Gimnasio");

            entity.HasOne(d => d.MetodoPago).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.MetodoPagoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pago_Metodo");

            entity.HasOne(d => d.CorteCaja).WithMany(p => p.Pagos)
                .HasPrincipalKey(p => new { p.GimnasioId, p.CorteCajaId })
                .HasForeignKey(d => new { d.GimnasioId, d.CorteCajaId })
                .HasConstraintName("FK_Pago_CorteCaja");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Pagos)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pago_Usuario");

            entity.HasOne(d => d.Ventum).WithMany(p => p.Pagos)
                .HasPrincipalKey(p => new { p.GimnasioId, p.VentaId })
                .HasForeignKey(d => new { d.GimnasioId, d.VentaId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pago_Venta");
        });

        modelBuilder.Entity<ParametroConfiguracion>(entity =>
        {
            entity.ToTable("ParametroConfiguracion");

            entity.HasIndex(e => new { e.GimnasioId, e.Activo }, "IX_ParametroConfiguracion_Gimnasio_Activo");

            entity.HasIndex(e => new { e.GimnasioId, e.Clave }, "UQ_ParametroConfiguracion_Gimnasio_Clave").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Clave).HasMaxLength(100);
            entity.Property(e => e.Descripcion).HasMaxLength(300);
            entity.Property(e => e.FechaActualizacion).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.TipoDato)
                .HasMaxLength(20)
                .HasDefaultValue("Texto");

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.ParametroConfiguracions)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ParametroConfiguracion_Gimnasio");
        });

        modelBuilder.Entity<PerfilGimnasio>(entity =>
        {
            entity.ToTable("PerfilGimnasio");

            entity.HasIndex(e => e.GimnasioId, "UQ_PerfilGimnasio_Gimnasio").IsUnique();

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

            entity.HasOne(d => d.Gimnasio).WithOne(p => p.PerfilGimnasio)
                .HasForeignKey<PerfilGimnasio>(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PerfilGimnasio_Gimnasio");
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

            entity.HasIndex(e => new { e.GimnasioId, e.Activo }, "IX_PlanMembresia_Gimnasio_Activo");

            entity.HasIndex(e => new { e.GimnasioId, e.Nombre }, "UQ_PlanMembresia_Gimnasio_Nombre").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.PlanMembresiaId }, "UQ_PlanMembresia_Gimnasio_Plan").IsUnique();

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

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.PlanMembresia)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlanMembresia_Gimnasio");
        });

        modelBuilder.Entity<PlantillaNotificacion>(entity =>
        {
            entity.ToTable("PlantillaNotificacion");

            entity.HasIndex(e => new { e.GimnasioId, e.TipoNotificacionId }, "IX_PlantillaNotificacion_Tipo");

            entity.HasIndex(e => new { e.GimnasioId, e.PlantillaNotificacionId }, "UQ_PlantillaNotificacion_Gimnasio_Plantilla").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Asunto).HasMaxLength(200);
            entity.Property(e => e.Canal).HasMaxLength(20);
            entity.Property(e => e.Nombre).HasMaxLength(150);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.PlantillaNotificacions)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlantillaNotificacion_Gimnasio");

            entity.HasOne(d => d.TipoNotificacion).WithMany(p => p.PlantillaNotificacions)
                .HasForeignKey(d => d.TipoNotificacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlantillaNotificacion_Tipo");
        });

        modelBuilder.Entity<PoliticaGimnasio>(entity =>
        {
            entity.ToTable("PoliticaGimnasio");

            entity.HasIndex(e => new { e.GimnasioId, e.Activo }, "IX_PoliticaGimnasio_Gimnasio_Activo");

            entity.HasIndex(e => new { e.GimnasioId, e.Clave }, "UQ_PoliticaGimnasio_Gimnasio_Clave").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Clave).HasMaxLength(100);
            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.FechaActualizacion).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.Valor).HasMaxLength(500);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.PoliticaGimnasios)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PoliticaGimnasio_Gimnasio");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.ToTable("Producto");

            entity.HasIndex(e => new { e.GimnasioId, e.CategoriaProductoId, e.Activo }, "IX_Producto_Categoria");

            entity.HasIndex(e => new { e.GimnasioId, e.Nombre }, "IX_Producto_Nombre");

            entity.HasIndex(e => new { e.GimnasioId, e.ProductoId }, "UQ_Producto_Gimnasio_Producto").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.CodigoBarras }, "UX_Producto_CodigoBarras")
                .IsUnique()
                .HasFilter("([CodigoBarras] IS NOT NULL)");

            entity.HasIndex(e => new { e.GimnasioId, e.Sku }, "UX_Producto_SKU")
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

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.Productos)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Producto_Gimnasio");

            entity.HasOne(d => d.CategoriaProducto).WithMany(p => p.Productos)
                .HasPrincipalKey(p => new { p.GimnasioId, p.CategoriaProductoId })
                .HasForeignKey(d => new { d.GimnasioId, d.CategoriaProductoId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Producto_Categoria");

            entity.HasOne(d => d.Marca).WithMany(p => p.Productos)
                .HasPrincipalKey(p => new { p.GimnasioId, p.MarcaId })
                .HasForeignKey(d => new { d.GimnasioId, d.MarcaId })
                .HasConstraintName("FK_Producto_Marca");

            entity.HasOne(d => d.UnidadMedidum).WithMany(p => p.Productos)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UnidadMedidaId })
                .HasForeignKey(d => new { d.GimnasioId, d.UnidadMedidaId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Producto_Unidad");
        });

        modelBuilder.Entity<ProductoProveedor>(entity =>
        {
            entity.HasKey(e => new { e.ProductoId, e.ProveedorId });

            entity.ToTable("ProductoProveedor");

            entity.HasIndex(e => new { e.GimnasioId, e.ProveedorId }, "IX_ProductoProveedor_Proveedor");

            entity.Property(e => e.CodigoProductoProveedor)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrecioCompra).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.ProductoProveedors)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoProveedor_Gimnasio");

            entity.HasOne(d => d.Producto).WithMany(p => p.ProductoProveedors)
                .HasPrincipalKey(p => new { p.GimnasioId, p.ProductoId })
                .HasForeignKey(d => new { d.GimnasioId, d.ProductoId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoProveedor_Producto");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.ProductoProveedors)
                .HasPrincipalKey(p => new { p.GimnasioId, p.ProveedorId })
                .HasForeignKey(d => new { d.GimnasioId, d.ProveedorId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoProveedor_Proveedor");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.ToTable("Proveedor");

            entity.HasIndex(e => new { e.GimnasioId, e.Nombre }, "IX_Proveedor_Nombre");

            entity.HasIndex(e => new { e.GimnasioId, e.ProveedorId }, "UQ_Proveedor_Gimnasio_Proveedor").IsUnique();

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

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Proveedor_Gimnasio");
        });

        modelBuilder.Entity<ReservacionActividad>(entity =>
        {
            entity.ToTable("ReservacionActividad");

            entity.HasIndex(e => new { e.GimnasioId, e.SocioId, e.FechaReservacion }, "IX_ReservacionActividad_Socio");

            entity.HasIndex(e => new { e.GimnasioId, e.ReservacionActividadId }, "UQ_ReservacionActividad_Gimnasio_Reservacion").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.ActividadProgramadaId, e.SocioId }, "UQ_ReservacionActividad_Socio").IsUnique();

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Reservada");
            entity.Property(e => e.FechaReservacion).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Observaciones).HasMaxLength(300);

            entity.HasOne(d => d.ActividadProgramadum).WithMany(p => p.ReservacionActividads)
                .HasPrincipalKey(p => new { p.GimnasioId, p.ActividadProgramadaId })
                .HasForeignKey(d => new { d.GimnasioId, d.ActividadProgramadaId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReservacionActividad_Actividad");

            entity.HasOne(d => d.Socio).WithMany(p => p.ReservacionActividads)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.SocioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReservacionActividad_Socio");
        });

        modelBuilder.Entity<ReservacionClase>(entity =>
        {
            entity.ToTable("ReservacionClase");

            entity.HasIndex(e => new { e.GimnasioId, e.SocioId, e.FechaReservacion }, "IX_ReservacionClase_Socio").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.ReservacionClaseId }, "UQ_ReservacionClase_Gimnasio_Reservacion").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.SesionClaseId, e.SocioId }, "UQ_ReservacionClase_SocioSesion").IsUnique();

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
                .HasPrincipalKey(p => new { p.GimnasioId, p.SesionClaseId })
                .HasForeignKey(d => new { d.GimnasioId, d.SesionClaseId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReservacionClase_Sesion");

            entity.HasOne(d => d.Socio).WithMany(p => p.ReservacionClases)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.SocioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReservacionClase_Socio");
        });

        modelBuilder.Entity<ReservacionServicio>(entity =>
        {
            entity.ToTable("ReservacionServicio");

            entity.HasIndex(e => new { e.GimnasioId, e.FechaServicio, e.Estado }, "IX_ReservacionServicio_Fecha");

            entity.HasIndex(e => new { e.GimnasioId, e.SocioId, e.FechaServicio }, "IX_ReservacionServicio_Socio");

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Reservada");
            entity.Property(e => e.FechaReservacion).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Observaciones).HasMaxLength(500);

            entity.HasOne(d => d.Usuario).WithMany(p => p.ReservacionServicios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioResponsableId })
                .HasConstraintName("FK_ReservacionServicio_Usuario");

            entity.HasOne(d => d.ContratacionServicio).WithMany(p => p.ReservacionServicios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.ContratacionServicioId, p.SocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.ContratacionServicioId, d.SocioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReservacionServicio_Contratacion");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.ToTable("Rol");

            entity.HasIndex(e => new { e.GimnasioId, e.Nombre }, "UQ_Rol_Gimnasio_Nombre").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.RolId }, "UQ_Rol_Gimnasio_Rol").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.FechaCreacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Nombre).HasMaxLength(80);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.Rols)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rol_Gimnasio");
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
            entity.ToTable("Rutina");

            entity.HasIndex(e => new { e.GimnasioId, e.UsuarioCreadorId }, "IX_Rutina_UsuarioCreador");

            entity.HasIndex(e => new { e.GimnasioId, e.RutinaId }, "UQ_Rutina_Gimnasio_Rutina").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Nivel).HasMaxLength(30);
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.Objetivo).HasMaxLength(100);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.Rutinas)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rutina_Gimnasio");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Rutinas)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioCreadorId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rutina_Usuario");
        });

        modelBuilder.Entity<RutinaSocio>(entity =>
        {
            entity.ToTable("RutinaSocio");

            entity.HasIndex(e => new { e.GimnasioId, e.RutinaId }, "IX_RutinaSocio_Rutina");

            entity.HasIndex(e => new { e.GimnasioId, e.SocioId, e.Estado }, "IX_RutinaSocio_Socio");

            entity.HasIndex(e => new { e.GimnasioId, e.RutinaSocioId }, "UQ_RutinaSocio_Gimnasio_RutinaSocio").IsUnique();

            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .HasDefaultValue("Activa");
            entity.Property(e => e.FechaAsignacion).HasDefaultValueSql("(CONVERT([date],getdate()))");
            entity.Property(e => e.Observaciones).HasMaxLength(500);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.RutinaSocios)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RutinaSocio_Gimnasio");

            entity.HasOne(d => d.Instructor).WithMany(p => p.RutinaSocios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.InstructorId })
                .HasForeignKey(d => new { d.GimnasioId, d.InstructorId })
                .HasConstraintName("FK_RutinaSocio_Instructor");

            entity.HasOne(d => d.Rutina).WithMany(p => p.RutinaSocios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.RutinaId })
                .HasForeignKey(d => new { d.GimnasioId, d.RutinaId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RutinaSocio_Rutina");

            entity.HasOne(d => d.Socio).WithMany(p => p.RutinaSocios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.SocioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RutinaSocio_Socio");
        });

        modelBuilder.Entity<SaldoSocio>(entity =>
        {
            entity.ToTable("SaldoSocio");

            entity.HasIndex(e => new { e.GimnasioId, e.SocioId, e.FechaMovimiento }, "IX_SaldoSocio_Socio").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.UsuarioId }, "IX_SaldoSocio_Usuario");

            entity.HasIndex(e => new { e.GimnasioId, e.VentaId }, "IX_SaldoSocio_Venta");

            entity.Property(e => e.Concepto).HasMaxLength(250);
            entity.Property(e => e.FechaMovimiento)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TipoMovimiento)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.SaldoSocios)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaldoSocio_Gimnasio");

            entity.HasOne(d => d.Socio).WithMany(p => p.SaldoSocios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.SocioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaldoSocio_Socio");

            entity.HasOne(d => d.Usuario).WithMany(p => p.SaldoSocios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SaldoSocio_Usuario");

            entity.HasOne(d => d.Ventum).WithMany(p => p.SaldoSocios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.VentaId })
                .HasForeignKey(d => new { d.GimnasioId, d.VentaId })
                .HasConstraintName("FK_SaldoSocio_Venta");
        });

        modelBuilder.Entity<SeguimientoEjercicio>(entity =>
        {
            entity.ToTable("SeguimientoEjercicio");

            entity.HasIndex(e => new { e.GimnasioId, e.RutinaSocioId, e.FechaRealizacion }, "IX_SeguimientoEjercicio_RutinaSocio_Fecha");

            entity.Property(e => e.FechaRealizacion).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Observaciones).HasMaxLength(500);
            entity.Property(e => e.PesoUtilizado).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.RepeticionesCompletadas).HasMaxLength(50);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.SeguimientoEjercicios)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeguimientoEjercicio_Gimnasio");

            entity.HasOne(d => d.EjercicioRutina).WithMany(p => p.SeguimientoEjercicios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.EjercicioRutinaId })
                .HasForeignKey(d => new { d.GimnasioId, d.EjercicioRutinaId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeguimientoEjercicio_EjercicioRutina");

            entity.HasOne(d => d.RutinaSocio).WithMany(p => p.SeguimientoEjercicios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.RutinaSocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.RutinaSocioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeguimientoEjercicio_RutinaSocio");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.ToTable("Servicio");

            entity.HasIndex(e => new { e.GimnasioId, e.CategoriaServicioId }, "IX_Servicio_Categoria");

            entity.HasIndex(e => new { e.GimnasioId, e.ServicioId }, "UQ_Servicio_Gimnasio_Servicio").IsUnique();

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.Nombre).HasMaxLength(150);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.CategoriaServicio).WithMany(p => p.Servicios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.CategoriaServicioId })
                .HasForeignKey(d => new { d.GimnasioId, d.CategoriaServicioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Servicio_CategoriaServicio");
        });

        modelBuilder.Entity<ServicioSucursal>(entity =>
        {
            entity.ToTable("ServicioSucursal");

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalId, e.Disponible }, "IX_ServicioSucursal_Sucursal");

            entity.HasIndex(e => new { e.GimnasioId, e.ServicioId, e.SucursalId }, "UQ_ServicioSucursal").IsUnique();

            entity.Property(e => e.Disponible).HasDefaultValue(true);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Servicio).WithMany(p => p.ServicioSucursals)
                .HasPrincipalKey(p => new { p.GimnasioId, p.ServicioId })
                .HasForeignKey(d => new { d.GimnasioId, d.ServicioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServicioSucursal_Servicio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.ServicioSucursals)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ServicioSucursal_Sucursal");
        });

        modelBuilder.Entity<SesionClase>(entity =>
        {
            entity.ToTable("SesionClase");

            entity.HasIndex(e => new { e.GimnasioId, e.Fecha, e.Estado, e.HoraInicio }, "IX_SesionClase_Fecha");

            entity.HasIndex(e => new { e.GimnasioId, e.SesionClaseId }, "UQ_SesionClase_Gimnasio_Sesion").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.HorarioClaseId, e.Fecha }, "UQ_SesionClase_HorarioFecha").IsUnique();

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
                .HasPrincipalKey(p => new { p.GimnasioId, p.HorarioClaseId })
                .HasForeignKey(d => new { d.GimnasioId, d.HorarioClaseId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SesionClase_Horario");
        });

        modelBuilder.Entity<Socio>(entity =>
        {
            entity.ToTable("Socio");

            entity.HasIndex(e => new { e.GimnasioId, e.Activo }, "IX_Socio_Gimnasio_Activo");

            entity.HasIndex(e => new { e.GimnasioId, e.ApellidoPaterno, e.ApellidoMaterno, e.Nombre }, "IX_Socio_Gimnasio_Nombre");

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalRegistroId }, "IX_Socio_Gimnasio_SucursalRegistro");

            entity.HasIndex(e => new { e.GimnasioId, e.SocioId }, "UQ_Socio_Gimnasio_Socio").IsUnique();

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

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.Socios)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Socio_Gimnasio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.Socios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalRegistroId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Socio_Sucursal");
        });

        modelBuilder.Entity<Sucursal>(entity =>
        {
            entity.ToTable("Sucursal");

            entity.HasIndex(e => new { e.GimnasioId, e.Activo }, "IX_Sucursal_Gimnasio_Activo");

            entity.HasIndex(e => new { e.GimnasioId, e.Codigo }, "UQ_Sucursal_Gimnasio_Codigo").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalId }, "UQ_Sucursal_Gimnasio_Sucursal").IsUnique();

            entity.HasIndex(e => e.GimnasioId, "UX_Sucursal_Principal")
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

            entity.HasOne(d => d.Gimnasio).WithOne(p => p.Sucursal)
                .HasForeignKey<Sucursal>(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sucursal_Gimnasio");
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

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalDestinoId, e.Estado, e.FechaSolicitud }, "IX_Traspaso_Destino").IsDescending(false, false, false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalOrigenId, e.FechaSolicitud }, "IX_Traspaso_Origen").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.Folio }, "UQ_TraspasoInventario_Folio").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.TraspasoInventarioId }, "UQ_TraspasoInventario_Gimnasio_Traspaso").IsUnique();

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

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.TraspasoInventarios)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Traspaso_Gimnasio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.TraspasoInventarioSucursals)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalDestinoId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Traspaso_Destino");

            entity.HasOne(d => d.SucursalNavigation).WithMany(p => p.TraspasoInventarioSucursalNavigations)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalOrigenId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Traspaso_Origen");

            entity.HasOne(d => d.Usuario).WithMany(p => p.TraspasoInventarios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Traspaso_Usuario");
        });

        modelBuilder.Entity<UnidadMedidum>(entity =>
        {
            entity.HasKey(e => e.UnidadMedidaId);

            entity.HasIndex(e => new { e.GimnasioId, e.Abreviatura }, "UQ_UnidadMedida_Abreviatura").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.UnidadMedidaId }, "UQ_UnidadMedida_Gimnasio_Unidad").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.Nombre }, "UQ_UnidadMedida_Nombre").IsUnique();

            entity.Property(e => e.Abreviatura)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.Nombre).HasMaxLength(50);

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.UnidadMedida)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnidadMedida_Gimnasio");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.ToTable("Usuario");

            entity.HasIndex(e => new { e.GimnasioId, e.Activo }, "IX_Usuario_Gimnasio_Activo");

            entity.HasIndex(e => new { e.GimnasioId, e.Correo }, "UQ_Usuario_Gimnasio_Correo").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.UsuarioId }, "UQ_Usuario_Gimnasio_Usuario").IsUnique();

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

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuario_Gimnasio");
        });

        modelBuilder.Entity<UsuarioRol>(entity =>
        {
            entity.HasKey(e => new { e.UsuarioId, e.RolId });

            entity.ToTable("UsuarioRol");

            entity.HasIndex(e => new { e.GimnasioId, e.RolId }, "IX_UsuarioRol_Rol");

            entity.Property(e => e.FechaAsignacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");

            entity.HasOne(d => d.Rol).WithMany(p => p.UsuarioRols)
                .HasPrincipalKey(p => new { p.GimnasioId, p.RolId })
                .HasForeignKey(d => new { d.GimnasioId, d.RolId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioRol_Rol");

            entity.HasOne(d => d.Usuario).WithMany(p => p.UsuarioRols)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioRol_Usuario");
        });

        modelBuilder.Entity<UsuarioSucursal>(entity =>
        {
            entity.HasKey(e => new { e.UsuarioId, e.SucursalId });

            entity.ToTable("UsuarioSucursal");

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalId, e.Activo }, "IX_UsuarioSucursal_Sucursal");

            entity.Property(e => e.Activo).HasDefaultValue(true);
            entity.Property(e => e.FechaAsignacion)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.UsuarioSucursals)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioSucursal_Sucursal");

            entity.HasOne(d => d.Usuario).WithMany(p => p.UsuarioSucursals)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuarioSucursal_Usuario");
        });

        modelBuilder.Entity<Ventum>(entity =>
        {
            entity.HasKey(e => e.VentaId);

            entity.HasIndex(e => new { e.GimnasioId, e.CajaId, e.FechaVenta }, "IX_Venta_Caja").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.Estado, e.FechaVenta }, "IX_Venta_Estado").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.SocioId, e.FechaVenta }, "IX_Venta_Socio").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalId, e.FechaVenta }, "IX_Venta_SucursalFecha").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.Folio }, "UQ_Venta_Folio").IsUnique();

            entity.HasIndex(e => new { e.GimnasioId, e.VentaId }, "UQ_Venta_Gimnasio_Venta").IsUnique();

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

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.Venta)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Venta_Gimnasio");

            entity.HasOne(d => d.Caja).WithMany(p => p.Venta)
                .HasPrincipalKey(p => new { p.GimnasioId, p.CajaId })
                .HasForeignKey(d => new { d.GimnasioId, d.CajaId })
                .HasConstraintName("FK_Venta_Caja");

            entity.HasOne(d => d.CorteCaja).WithMany(p => p.Venta)
                .HasPrincipalKey(p => new { p.GimnasioId, p.CorteCajaId })
                .HasForeignKey(d => new { d.GimnasioId, d.CorteCajaId })
                .HasConstraintName("FK_Venta_CorteCaja");

            entity.HasOne(d => d.Socio).WithMany(p => p.Venta)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.SocioId })
                .HasConstraintName("FK_Venta_Socio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.Venta)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Venta_Sucursal");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Venta)
                .HasPrincipalKey(p => new { p.GimnasioId, p.UsuarioId })
                .HasForeignKey(d => new { d.GimnasioId, d.UsuarioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Venta_Usuario");
        });

        modelBuilder.Entity<VisitaSocio>(entity =>
        {
            entity.ToTable("VisitaSocio");

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalId, e.SocioId }, "IX_VisitaSocio_Activas").HasFilter("([FechaSalida] IS NULL)");

            entity.HasIndex(e => new { e.GimnasioId, e.SocioId, e.FechaEntrada }, "IX_VisitaSocio_Socio").IsDescending(false, false, true);

            entity.HasIndex(e => new { e.GimnasioId, e.SucursalId, e.FechaEntrada }, "IX_VisitaSocio_Sucursal").IsDescending(false, false, true);

            entity.Property(e => e.FechaEntrada)
                .HasPrecision(0)
                .HasDefaultValueSql("(sysutcdatetime())");
            entity.Property(e => e.FechaSalida).HasPrecision(0);
            entity.Property(e => e.Observaciones).HasMaxLength(250);
            entity.Property(e => e.TipoRegistro)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Entrada");

            entity.HasOne(d => d.Gimnasio).WithMany(p => p.VisitaSocios)
                .HasForeignKey(d => d.GimnasioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VisitaSocio_Gimnasio");

            entity.HasOne(d => d.AreaGimnasio).WithMany(p => p.VisitaSocios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.AreaGimnasioId })
                .HasForeignKey(d => new { d.GimnasioId, d.AreaGimnasioId })
                .HasConstraintName("FK_VisitaSocio_Area");

            entity.HasOne(d => d.MembresiaSocio).WithMany(p => p.VisitaSocios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.MembresiaSocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.MembresiaSocioId })
                .HasConstraintName("FK_VisitaSocio_Membresia");

            entity.HasOne(d => d.Socio).WithMany(p => p.VisitaSocios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SocioId })
                .HasForeignKey(d => new { d.GimnasioId, d.SocioId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VisitaSocio_Socio");

            entity.HasOne(d => d.Sucursal).WithMany(p => p.VisitaSocios)
                .HasPrincipalKey(p => new { p.GimnasioId, p.SucursalId })
                .HasForeignKey(d => new { d.GimnasioId, d.SucursalId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VisitaSocio_Sucursal");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
