# Módulo 05 — Clases, actividades y servicios

## Propósito
Oferta de clases grupales, actividades programadas y servicios adicionales (spas, entrenamientos personales), con horarios, instructores, reservaciones y asistencias.

## Tablas (16)
`Clase` · `TipoClase` · `AreaClase` · `AreaGimnasio` · `SesionClase` · `HorarioClase` · `Instructor` · `ReservacionClase` · `ListaEsperaClase` · `AsistenciaClase` · `Actividad` · `ActividadProgramadum` · `AsistenciaActividad` · `ReservacionActividad` · `Servicio` · `CategoriaServicio` · `ServicioSucursal` · `ReservacionServicio`

## Relaciones clave
- `Clase` N—1 `TipoClase` · N—1 `CatGimnasio` · N—M `AreaGimnasio` (AreaClase)
- `Clase` 1—N `SesionClase` / `HorarioClase` → `DiaSemana`
- `Instructor` 1—0..1 `Usuario` (cuenta de sistema)
- `SesionClase` 1—N `ReservacionClase` / `AsistenciaClase` / `ListaEsperaClase`
- `Actividad` 1—N `ActividadProgramadum` 1—N `ReservacionActividad` / `AsistenciaActividad`
- `Servicio` N—M `Sucursal` (ServicioSucursal) · 1—N `ContratacionServicio` / `ReservacionServicio`

## Alcance MVP (Fase 2)
- CRUD de tipos de clase, clases y horarios semanales por gimnasio
- Reservación con cupo y lista de espera automática
- Check-in de asistencia a clase
- **Fuente de datos para la landing page** (secciones Clases y Horarios del PR #1 de Gimnasio.UI)

## Estado
Solo modelo de datos.

## Preguntas abiertas
- ¿Cupo máximo configurable por clase (parámetro) en el MVP?
- ¿Cancelación con antelación mínima (parámetro por gimnasio)?
