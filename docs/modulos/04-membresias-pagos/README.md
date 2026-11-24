# Módulo 04 — Membresías y pagos

## Propósito
Catálogo de planes, contratación/renovación de membresías por socio y registro de cobros.

## Tablas (7)
`PlanMembresium` · `MembresiaSocio` · `MembresiaSucursal` · `HistorialMembresium` · `MetodoPago` · `Pago` · `ContratacionServicio`

## Relaciones clave
- `PlanMembresium` N—1 `CatGimnasio` (cada gimnasio define sus planes)
- `MembresiaSocio` N—1 `Socio` · N—1 `PlanMembresium` · N—1 `Sucursal` (sucursal de compra)
- `MembresiaSocio` **autorreferencia** `MembresiaAnteriorId` → cadena de renovaciones
- `MembresiaSocio` 1—N `Pago` / `HistorialMembresium` / `VisitaSocio` / `AccesoSocio`
- `MembresiaSucursal`: disponibilidad de membresías por sucursal

## Reglas de negocio del núcleo
- `PrecioContratado` se congela al momento de la venta (no cambia si el plan sube de precio)
- `FechaInicio/FechaFin` definen vigencia; el estado (`Estado`) gobierna activo/vencida/cancelada
- Renovación = nueva fila encadenada por `MembresiaAnteriorId`, nunca update de la vigencia anterior
- `ConfiguracionMembresium` (1—1 por gimnasio) permite reglas de membresía distintas por local

## Alcance MVP (Fase 1)
- CRUD de planes por gimnasio
- Venta/renovación de membresía con generación de `Pago` (integración con caja en Fase 3)
- Consulta de vigencia del socio (usada por accesos y la landing futura)

## Estado
Solo modelo de datos.

## Preguntas abiertas
- ¿Membresías familiares/corporativas (descuentos) en el MVP?
- ¿Congelación de membresía por enfermedad (pausas)?
