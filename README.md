# Gimnasio — API del Sistema de Control de Gimnasios 🏋️

Sistema de gestión para gimnasios **multi-tenant**: una sola plataforma que opera **varios gimnasios** (cada uno con sus sucursales, socios, membresías, clases, caja e inventario), sin que los datos de un gimnasio se mezclen con los de otro.

> 📖 **¿Primera vez en el proyecto?** Empieza por [`docs/00-contexto-y-trasfondo.md`](docs/00-contexto-y-trasfondo.md) — el trasfondo del negocio, el glosario y la historia del proyecto explicados para cualquier persona, técnica o no.

## ¿Qué resuelve este sistema?

Un gimnasio necesita administrar mucho más que pesas: socios y sus membresías, accesos y asistencia, clases con horarios e instructores, rutinas de entrenamiento, punto de venta, caja, inventario, proveedores y comunicaciones. Este proyecto es la **API** (el "cerebro" sin interfaz gráfica) que centraliza toda esa operación, y está diseñado para que **cada gimnasio cliente tenga sus propias reglas y campos** sin que eso rompa el corazón del sistema.

## Estado del proyecto

| Aspecto | Estado |
|---|---|
| Modelo de datos | ✅ 76 entidades modeladas (76 tablas) — revisar [`docs/dominio/`](docs/dominio/00-modelo-actual.md) |
| Módulos implementados en código | 🔨 1 de 10 (Seguridad/Usuarios) — resto planificado en [`docs/roadmap-mvp.md`](docs/roadmap-mvp.md) |
| Frontend (landing pública) | ✅ propuesta en el repo hermano [`Gimnasio.UI`](https://github.com/Developer-net-web/Gimnasio.UI) |
| Fase actual | **MVP con prioridad en base de datos** (Fase 0–1 del roadmap) |

## Stack y arquitectura

```
┌──────────────────────┐       HTTP/JSON       ┌──────────────────────┐       EF Core 8       ┌──────────────┐
│  Gimnasio.UI         │  ───────────────────► │  Gimnasio (este repo)│  ───────────────────► │  SQL Server  │
│  Angular 22          │                       │  API .NET 8 / C#     │                       │  2008 → 2022 │
└──────────────────────┘                       └──────────────────────┘                       └──────────────┘
```

- **Frontend:** Angular 22 · repo hermano [`Gimnasio.UI`](https://github.com/Developer-net-web/Gimnasio.UI)
- **Backend:** .NET 8 / C# con arquitectura en capas:
  - `Gimnasio.API` — controllers (puntos de entrada HTTP)
  - `Gimnasio.API.Application` — servicios, DTOs e interfaces (reglas de aplicación)
  - `Gimnasio.API.Infrastructure` — EF Core, repositorios, mapeos (acceso a datos)
  - `Gimnasio.Domain` — entidades del dominio (el negocio)
- **Base de datos:** SQL Server — soportados **2008/R2 (stack legacy) hasta 2022** mediante nivel de compatibilidad configurable (ver [retrocompatibilidad](docs/base-datos/02-retrocompatibilidad-entornos.md))

## Inicio rápido

### 0. Requisitos
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) (`dotnet --list-sdks` debe mostrar 8.x)
- SQL Server local (cualquier versión 2008–2022; cada máquina configura la suya)

### 1. Configurar TU máquina (sin tocar nada versionado)

```powershell
copy Gimnasio.API\appsettings.local.example.json Gimnasio.API\appsettings.local.json
# edítalo con tu servidor/instancia y tu base de datos
```

Si tu SQL Server es **2008/R2**, pon además `"CompatibilityLevel": 100` en ese mismo archivo. Guía completa: [`docs/base-datos/02-retrocompatibilidad-entornos.md`](docs/base-datos/02-retrocompatibilidad-entornos.md).

### 2. Crear una BD de desarrollo (solo si no tienes una ya)

```powershell
dotnet run --project <ruta-a>\tools\DbInit    # crea Gimnasio_Dev con las 83 tablas + datos semilla
```

*(omite este paso si vas a usar una base de datos existente)*

### 3. Arrancar

```powershell
dotnet run --project Gimnasio.API
# Swagger: http://localhost:5000/swagger  (o el puerto que indique la consola)
```

## Documentación

| Documento | Contenido |
|---|---|
| [`docs/00-contexto-y-trasfondo.md`](docs/00-contexto-y-trasfondo.md) | ⭐ Trasfondo del negocio, glosario e historia del proyecto |
| [`docs/convenciones-desarrollo.md`](docs/convenciones-desarrollo.md) | Cómo trabajamos: ramas, PRs, módulos, bitácora |
| [`docs/roadmap-mvp.md`](docs/roadmap-mvp.md) | Fases del MVP priorizando la base de datos |
| [`docs/dominio/`](docs/dominio/00-modelo-actual.md) | Modelo de dominio: entidades, núcleo inmutable, multi-tenancy |
| [`docs/base-datos/`](docs/base-datos/00-estandares.md) | Estándares de BD, migración SQL 2008 y retrocompatibilidad |
| [`docs/modulos/`](docs/modulos/README.md) | Los 10 módulos del dominio, uno por carpeta |
| [`docs/bitacora/`](docs/bitacora/README.md) | Registro cronológico de cada implementación |

## Flujos de ramas

```
feature/<nombre>  ──PR──►  desarrollo  ──►  qa  ──►  produccion  ──►  master
```

## Contribuciones recientes

| # | Implementación | PR |
|---|---|---|
| 0001 | Landing page (frontend) | [Gimnasio.UI #1](https://github.com/Developer-net-web/Gimnasio.UI/pull/1) |
| 0002 | Base de datos MVP: dominio, tenancy y migración SQL 2008 | [#1](https://github.com/Developer-net-web/Gimnasio/pull/1) |
| 0003 | Verificación de entorno y API | (parte de la anterior) |
| 0004 | Fix endpoint de usuario + mapper | [#2](https://github.com/Developer-net-web/Gimnasio/pull/2) |
| 0005 | Retrocompatibilidad de entornos y configuración dinámica | [#2](https://github.com/Developer-net-web/Gimnasio/pull/2) |
