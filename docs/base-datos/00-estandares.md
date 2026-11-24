# 🗄️ Estándares de base de datos

> Derivados de los patrones ya existentes en los 76 modelos actuales. El objetivo es que cualquier tabla nueva sea idéntica en estructura y comportamiento a las existentes.

## Convenciones de nombres (actuales, a conservar)

| Elemento | Convención | Ejemplo |
|---|---|---|
| Tabla | `PascalCase`, singular por concepto | `MembresiaSocio`, `HorarioClase` |
| PK | `<Entidad>Id` | `SocioId`, `MembresiaSocioId` |
| FK | `<EntidadReferenciada>Id` | `GimnasioId`, `PlanMembresiaId` |
| Booleanos | `Activo`, `Permitir…` | `Activo`, `PermitirReservaciones` |
| Fechas de auditoría | `FechaRegistro` / `FechaCreacion` + `FechaActualizacion?` | — |
| Concurrency token | `Version` (rowversion) | — |

## Reglas estructurales

1. **Todo PK es `INT IDENTITY`** (conservar; no migrar a GUID en el MVP).
2. **Todo dato de negocio lleva `GimnasioId`** (ver [`../dominio/03-multi-tenancy.md`](../dominio/03-multi-tenancy.md)).
3. **`Version ROWVERSION` obligatoria** en tablas transaccionales (concurrencia optimista).
4. **Borrado lógico**: `Activo BIT NOT NULL DEFAULT 1`. Prohibido `DELETE` físico en tablas de dominio.
5. **Strings**: `NVARCHAR` siempre (soporte Unicode), longitudes explícitas (sin `MAX` salvo observaciones/URLs).
6. **Dinero**: `DECIMAL(18,2)`, jamás `FLOAT` (ya se cumple: `PrecioContratado`, `Descuento`…).
7. **Fechas**: `DATETIME2` para instantes, `DATE` para fechas puras (el modelo ya usa `DateOnly` en EF).
8. **Catálogos**: tablas pequeñas de referencia (`DiaSemana`, `MetodoPago`, `TipoNotificacion`, `UnidadMedida`, `GrupoMuscular`, `Marca`) con **seed versionado** en migraciones.

## Índices

- Todo FK lleva índice.
- Índices de negocio **inician por `GimnasioId`**.
- Unicidad por tenant: `UNIQUE (GimnasioId, <campo>)` donde aplique (`Usuario.Correo`, `CatGimnasio.Codigo`).
- Unicidad filtrada donde el estado importa: `MembresiaSocio` activa única por socio (`WHERE Activo = 1`).

## Gestión de cambios

- **Migraciones de EF Core versionadas** en el repo (a activar en Fase 0 — hoy no existe carpeta `Migrations/`).
- Nunca `ALTER TABLE` manual contra la BD.
- Cambios al núcleo inmutable → ADR + PR.
- Cada migración debe incluir su **seed/down** reversible y correr en un ambiente de pruebas antes de `qa`.

## Relación modelo ↔ BD

Los modelos actuales se generaron por **scaffold** (database-first). Para el MVP se mantiene esa dirección:

1. Diseño/documento del cambio (docs/dominio)
2. Migración de EF Core generada
3. Esquema actualizado + modelos re-scaffold/validados
4. Bitácora actualizada
