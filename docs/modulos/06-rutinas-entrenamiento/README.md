# Módulo 06 — Rutinas y entrenamiento

## Propósito
Diseño de rutinas por socio con ejercicios, días, series/repeticiones y seguimiento de progreso.

## Tablas (9)
`Rutina` · `RutinaSocio` · `DiaRutina` · `Ejercicio` · `EjercicioRutina` · `GrupoMuscular` · `SeguimientoEjercicio` · `DiaSemana` · `UnidadMedidum`

## Relaciones clave
- `Rutina` N—1 `Usuario` (entrenador que la diseña) · N—1 `CatGimnasio`
- `Rutina` 1—N `DiaRutina` (por `DiaSemana`) · 1—N `EjercicioRutina` (series/repeticiones/carga por ejercicio)
- `RutinaSocio`: asignación de rutina a socio (histórico)
- `Ejercicio` N—1 `GrupoMuscular` · medidas en `UnidadMedidum`
- `SeguimientoEjercicio`: registros reales del socio por ejercicio

## Alcance MVP (Fase 2)
- Biblioteca de ejercicios por gimnasio (catálogo + grupo muscular)
- Asignar rutina semanal a un socio (plantilla → rutina del socio)
- Registro de seguimiento (peso/repeticiones realizadas)

## Estado
Solo modelo de datos.

## Preguntas abiertas
- ¿Plantillas de rutina compartidas entre gimnasios o privadas por tenant?
- ¿Videos/URL de demostración por ejercicio?
