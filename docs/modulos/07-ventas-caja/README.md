# Módulo 07 — Ventas y caja

## Propósito
Punto de venta (productos, servicios, membresías), control de caja física, movimientos y cortes.

## Tablas (7)
`Ventum` · `DetalleVentum` · `CategoriaVentum` · `Caja` · `MovimientoCaja` · `CorteCaja` · `MetodoPago`

## Relaciones clave
- `Ventum` N—1 `Socio?` (venta sin socio según `ConfiguracionGeneral.PermitirVentaSinSocio`) · N—1 `Usuario` (quien vende) · N—1 `Caja`
- `Ventum` 1—N `DetalleVentum` (cada línea puede referenciar producto, servicio o `MembresiaSocio` — la navegación ya existe)
- `Caja` 1—N `MovimientoCaja` · 1—N `CorteCaja` (con usuario que abre/cierra)

## Reglas de negocio del núcleo
- Toda venta genera movimientos de caja trazables (`MovimientoCaja`)
- Un corte cuadra `MovimientoCaja` vs efectivo físico; no se puede vender en caja cerrada
- `MetodoPago` es catálogo por gimnasio (efectivo, tarjeta, transferencia…)

## Alcance MVP (Fase 3)
- Abrir/cerrar turno de caja con corte
- Venta rápida: productos + membresía en un ticket con varios métodos de pago
- Reporte de ventas del día por sucursal

## Estado
Solo modelo de datos.

## Preguntas abiertas
- ¿Facturación fiscal en el MVP o solo ticket interno?
- ¿Devoluciones/cancelaciones de venta (nota de crédito)?
