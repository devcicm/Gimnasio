# 📚 Documentación — Sistema de Control de Gimnasios

> Stack: **Angular 22** (frontend) · **.NET 8 / C#** (API) · **SQL Server** (base de datos)
> Enfoque: MVP con **base de datos y dominio primero**. Núcleo ERP **inmutable** + extensible por gimnasio (multi-tenant).

## ⭐ Empieza aquí

**[`00-contexto-y-trasfondo.md`](00-contexto-y-trasfondo.md)** — qué es este proyecto, para qué existe, quién participa, cómo empezó esta etapa y el glosario completo. Escrito para cualquier persona, técnica o no.

## Mapa de la documentación

| Documento | Contenido |
|---|---|
| [`00-contexto-y-trasfondo.md`](00-contexto-y-trasfondo.md) | ⭐ Trasfondo del negocio, historia, principios y glosario |
| [`convenciones-desarrollo.md`](convenciones-desarrollo.md) | Flujo de trabajo, ramas, PRs, estructura de módulos/features y bitácora |
| [`roadmap-mvp.md`](roadmap-mvp.md) | Fases del MVP priorizando base de datos y dominio |
| [`bitacora/`](bitacora/) | Registro cronológico de cada implementación (qué, dónde, por qué) |
| [`dominio/`](dominio/) | Modelo de dominio: inventario de entidades, núcleo inmutable, extensibilidad, multi-tenancy |
| [`base-datos/`](base-datos/00-estandares.md) | Estándares de BD, migración de SQL Server 2008 → actual y retrocompatibilidad de entornos |
| [`modulos/`](modulos/README.md) | Un módulo (bounded context) por carpeta, con sus tablas, relaciones y alcance MVP |

## Reglas de oro

1. **El núcleo del dominio es inmutable**: las tablas y campos base definidos en [`dominio/01-nucleo-inmutable.md`](dominio/01-nucleo-inmutable.md) no se alteran; toda necesidad nueva de un gimnasio se resuelve con los mecanismos de extensión de [`dominio/02-extension-por-gimnasio.md`](dominio/02-extension-por-gimnasio.md).
2. **Todo dato es del gimnasio (tenant)**: toda tabla de negocio lleva `GimnasioId`. Ninguna consulta puede omitir el filtro de tenant.
3. **Todo cambio se documenta** en la bitácora y, si toca el dominio, con un ADR (Registro de Decisión de Arquitectura).
4. **La BD manda**: los modelos de EF Core se generan/validan contra la base de datos; cada cambio de esquema se versiona en migraciones.
