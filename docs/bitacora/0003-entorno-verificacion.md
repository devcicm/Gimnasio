# 0003 — Preparación del entorno y verificación de la API

- **Fecha:** 2026-11-24
- **Repo:** Gimnasio · rama `feature/base-datos-mvp`
- **Estado:** documentado (sin cambios de código del repo)

## Qué

Preparación y verificación end-to-end del entorno local de desarrollo:

| Componente | Resultado |
|---|---|
| .NET SDK | ✅ 8.0.206 instalado (el proyecto es `net8.0`) |
| SQL Server | ✅ **SQL Server 2022 Developer** corriendo en local (`localhost`) — compatible con EF Core 8 |
| Compilación | ✅ `dotnet build` — **0 errores**, 87 warnings (ver hallazgo #1) |
| Base de datos | ✅ `Gimnasio_Dev` creada con **83 tablas**, nivel de compatibilidad **160** (SQL 2022) |
| API | ✅ Arranca correctamente; Swagger responde 200 |
| Escritura/lectura EF → SQL | ✅ Semilla de prueba: Gimnasio `#1 POWER GYM Central` + Usuario `#1 Admin` insertados y leídos vía EF Core |

## Herramientas creadas (fuera del repo, `B:\GYM\tools\DbInit`)

Pequeño inicializador de consola que: 1) crea la BD local con `EnsureCreated()` generando el DDL completo desde los 76 modelos, y 2) siembra datos de prueba. Sirve para que cualquier colaborador levante el entorno en un comando:

```bash
dotnet run --project B:\GYM\tools\DbInit
```

La conexión de la API se sobrescribe por variable de entorno (sin tocar el repo):

```
ConnectionStrings__GimnasioConnection="Server=localhost;Database=Gimnasio_Dev;Trusted_Connection=True;TrustServerCertificate=True"
```

## Hallazgos nuevos

### 1. `UsuarioMapper` (Mapperly) mapea cero campos — 87 warnings RMG012/RMG020
La entidad de dominio `Gimnasio.Domain/Entities/Usuario` usa `IdUsuario` y solo `Nombre`, mientras el modelo de persistencia usa `UsuarioId` + 30 campos. Las convenciones de Mapperly no coinciden, así que el mapeo generado está vacío. **Consecuencia:** cualquier uso futuro del mapper pierde datos silenciosamente. *Recomendación:* alinear nombres de propiedades (`UsuarioId`, incluir `GimnasioId`) o configurar mapeos explícitos.

### 2. El único endpoint implementado falla — `POST api/Usuario` → HTTP 500
`UsuarioRepository.AgregarAsync` inserta un `Usuario` con solo `Nombre`; EF lanza:

```
System.InvalidOperationException: The value of 'Usuario.GimnasioId' is unknown when attempting to save changes.
```

Además faltan campos NOT NULL (`Correo`, `TipoAutenticacion`, `FechaCreacion`). **Confirma el gap de tenancy documentado en [`../dominio/03-multi-tenancy.md`](../dominio/03-multi-tenancy.md)**: nada asigna el `GimnasioId` del contexto. Es código en progreso del dueño; no se tocó sin su aprobación. La corrección natural queda apuntada para la Fase 1 (tenant context + DTO completo).

### 3. El DbContext expone los DbSets con nombres de scaffold
Ej.: `CatGimnasios` (no `Gimnasios`), `Actividads`, `Ventum`. Deuda de estilo ya registrada en [`../dominio/00-modelo-actual.md`](../dominio/00-modelo-actual.md).

## Impacto en BD / dominio

Ninguno en el repo. La BD local `Gimnasio_Dev` es de desarrollo y valida que el modelo genera DDL correcto (83 tablas) en SQL Server 2022 con compatibilidad 160 — el destino recomendado en [`../base-datos/01-migracion-sql-server-2008.md`](../base-datos/01-migracion-sql-server-2008.md).

## Pendientes

- Definir con el dueño si se corrige `UsuarioMapper` + endpoint (pequeño PR de Fase 1)
- Recibir el `.bak` legacy para el análisis comparativo
