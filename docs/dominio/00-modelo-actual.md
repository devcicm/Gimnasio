# 📋 Modelo actual — inventario de entidades

> Analizado sobre rama `desarrollo` (commit `97d8d48`, "Actualizacion de modelos"). Fuente: `GimnasioDbContext.cs` (76 entidades configuradas con `ToTable`).

## Patrones detectados (uniformes en casi todas las tablas)

| Patrón | Implementación | Significado |
|---|---|---|
| **Multi-tenant** | `GimnasioId int` FK → `CatGimnasio` | Toda fila pertenece a un gimnasio |
| **Auditoría** | `FechaRegistro` / `FechaCreacion`, `FechaActualizacion?` | Creación y última modificación |
| **Estado** | `Activo bool` | Borrado lógico / habilitación |
| **Concurrencia** | `Version byte[]` (rowversion) | Bloqueo optimista al actualizar |
| **Naturaleza** | Modelos `partial class` generados por scaffold (database-first) | La BD es la fuente de verdad actual |

⚠️ **Gap**: el DbContext **no** aplica filtros globales de tenant ni tiene migraciones versionadas. Ver [`03-multi-tenancy.md`](03-multi-tenancy.md).

## Inventario por módulo (76 tablas)

### 1. Seguridad y usuarios (6)
`Usuario`, `Rol`, `Permiso`, `RolPermiso`, `UsuarioRol`, `UsuarioSucursal`

### 2. Tenancy y configuración (10)
`CatGimnasio`, `Sucursal`, `PerfilGimnasio`, `PoliticaGimnasio`, `ConfiguracionGeneral`, `ConfiguracionMembresium`, `ParametroConfiguracion`, `HorarioSucursal`, `ExcepcionHorarioSucursal`, `DiaSemana`

### 3. Socios (10)
`Socio`, `SaldoSocio`, `VisitaSocio`, `AccesoSocio`, `Documento`, `CategoriaDocumento`, `EvaluacionFisica`, `ObjetivoFisico`, `HistorialObjetivoFisico`, `IncidenciaOperativa`

### 4. Membresías y pagos (7)
`PlanMembresium`, `MembresiaSocio`, `MembresiaSucursal`, `HistorialMembresium`, `MetodoPago`, `Pago`, `ContratacionServicio`

### 5. Clases, actividades y servicios (16)
`Clase`, `TipoClase`, `AreaClase`, `AreaGimnasio`, `SesionClase`, `HorarioClase`, `Instructor`, `ReservacionClase`, `ListaEsperaClase`, `AsistenciaClase`, `Actividad`, `ActividadProgramadum`, `AsistenciaActividad`, `ReservacionActividad`, `Servicio`, `ServicioSucursal`, `ReservacionServicio`

### 6. Rutinas y entrenamiento (9)
`Rutina`, `RutinaSocio`, `DiaRutina`, `Ejercicio`, `EjercicioRutina`, `GrupoMuscular`, `SeguimientoEjercicio`, `DiaSemana`, `UnidadMedidum`

### 7. Ventas y caja (7)
`Ventum`, `DetalleVentum`, `CategoriaVentum`, `Caja`, `MovimientoCaja`, `CorteCaja`, `MetodoPago`

### 8. Inventario y compras (12)
`Producto`, `CategoriaProducto`, `Marca`, `UnidadMedidum`, `InventarioSucursal`, `MovimientoInventario`, `TraspasoInventario`, `DetalleTraspasoInventario`, `Proveedor`, `ProductoProveedor`, `CompraProveedor`, `DetalleCompraProveedor`

### 9. Comunicaciones (7)
`Comunicado`, `ComunicadoLectura`, `Notificacion`, `NotificacionLectura`, `PlantillaNotificacion`, `TipoNotificacion`, `HistorialNotificacion`

### 10. Servicios adicionales del gimnasio
`Servicio`, `CategoriaServicio`, `ServicioSucursal`, `ContratacionServicio`, `ReservacionServicio`

> **Nota de nomenclatura**: los nombres pluralizados generados por el scaffold son irregulares (`Actividads`, `MembresiaSucursals`, `Ventum`, `Rols`, `CategoriaVentum`). No romper nada ya publicado, pero queda registrado como deuda de estilo a resolver con el dueño.

## Estado de implementación

Solo el módulo **Seguridad/Usuarios** tiene controller, service, repository y DTOs (`UsuarioController`). Los demás 9 módulos existen solo en la capa de datos.
