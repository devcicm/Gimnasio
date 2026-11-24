# 0002 — Base de datos MVP: dominio, tenancy y migración SQL Server 2008

- **Fecha:** 2026-11-24
- **Repo:** Gimnasio · rama `feature/base-datos-mvp` (desde `desarrollo`)
- **Estado:** en revisión

## Qué

1. **Estructura de carpetas** para módulos/features en código y documentación (`docs/modulos/`, `Application/Features/`).
2. **Documentación completa del dominio**: inventario de las 76 entidades actuales agrupadas en 10 módulos, núcleo ERP inmutable con relaciones y cardinalidad, estrategia de extensibilidad por gimnasio y modelo multi-tenant.
3. **Plan de migración** de la BD legacy de SQL Server 2008 a versión actual, con la restricción dura detectada: EF Core 8 requiere SQL Server 2012+.
4. **Estándares de base de datos** derivados de los patrones ya existentes en los modelos.

## Por qué

El MVP debe priorizar la base de datos: el modelo ya existe (76 tablas con `GimnasioId`), pero falta documentarlo, protegerlo (filtros de tenant, migraciones versionadas) y desbloquear la BD legacy para poder operar con EF Core 8.

## Hallazgos clave del análisis

| Hallazgo | Detalle |
|---|---|
| ✅ Multi-tenancy en datos | `CatGimnasio` + columna `GimnasioId` en ~todas las tablas de negocio |
| ⚠️ Tenancy sin enforcement | El `DbContext` **no aplica `HasQueryFilter`** por tenant: una consulta mal escrita puede cruzar gimnasios |
| ✅ Patrón de auditoría uniforme | `FechaRegistro/FechaCreacion`, `Activo`, `Version` (rowversion) en casi todas las tablas |
| ✅ Reglas por gimnasio ya previstas | `ConfiguracionGeneral` (toggles), `ParametroConfiguracion` (clave/valor/tipo), `PoliticaGimnasio` |
| ⚠️ Sin migraciones EF | El esquema se gestiona a mano (modelos generados por scaffold, sin carpeta `Migrations/`) |
| ❌ BD legacy incompatible | SQL Server 2008 no soportado por el proveedor EF Core 8 (requiere 2012+); `OPENJSON` de EF8 recomienda compat ≥130 |

## Impacto en BD / dominio

Ningún cambio de esquema en este PR: es documentación + estructura. Las decisiones que **sí** tocarán esquema quedan propuestas y marcadas como pendientes de aprobación (query filters, índices compuestos por tenant, tabla de campos extendidos).

## Pendientes

- Recibir el archivo `.bak` (o script de esquema) de la BD SQL 2008 para analizar tablas/campos reales
- Aplicar Fase 0 del [roadmap](../roadmap-mvp.md) tras aprobación
