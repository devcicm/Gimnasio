# 0005 — Retrocompatibilidad de entornos y configuración dinámica

- **Fecha:** 2026-11-26
- **Repo:** Gimnasio · rama `fix/usuario-endpoint` (mismo PR que 0004)
- **Estado:** en revisión

## Qué

El propietario probó las PRs y obtuvo errores de base de datos al arrancar: su stack es **SQL Server 2008** (que no va a actualizar) y EF Core 8 genera SQL incompatible (`OPENJSON`, `OFFSET/FETCH`). Además, la cadena de conexión versionada apuntaba hardcodeada a su máquina (`ALEJANDRO\SQLEXPRESS`), lo que rompe cualquier otro entorno.

Solución implementada (sin cambiar una línea de lógica de negocio):

1. **Nivel de compatibilidad EF dinámico** (`Database:CompatibilityLevel`): EF Core 8 genera SQL según el nivel configurado — `<130` evita `OPENJSON` (usa `IN`), `<110` usa `ROW_NUMBER` en paginación. El propietario configura `100` y su SQL Server 2008 funciona con el mismo código. El valor resuelto se registra en consola al arrancar.
2. **Configuración por máquina sin hardcode**: `appsettings.local.json` (gitignored, con plantilla `appsettings.local.example.json` versionada) cargado opcionalmente desde `Program.cs`; variables de entorno siguen teniendo precedencia. `appsettings.json` queda con valores neutros (`localhost`).
3. **DbInit dinámico**: acepta argumento o variable de entorno `GIMNASIO_DB_CONNECTION`.
4. **Documentación completa** en `docs/base-datos/02-retrocompatibilidad-entornos.md`: matriz de compatibilidad, recetas por entorno (propietario/collaborator), explicación de los subrayados rojos del mapper en IDE (source generator + .NET 8 SDK) y política anti-hardcode.

## Verificación (ambos entornos simulados en esta máquina)

| Escenario | Configuración | Resultado |
|---|---|---|
| Stack nuevo (default) | `appsettings.json` → nivel 160 | ✅ arranque con log `CompatibilityLevel EF: 160` + POST 200 |
| Stack viejo (propietario) | `appsettings.local.json` → nivel 100 | ✅ arranque con log `CompatibilityLevel EF: 100` + POST 200 (SQL legacy generado) |
| Archivo local fuera de git | `git check-ignore` | ✅ ignorado correctamente |
| Compilación | — | ✅ 0 errores, 0 warnings |

## Impacto en BD / dominio

Ningún cambio de esquema. Cambios de configuración: `appsettings.json` ahora tiene default neutro — **los que ya tenían su BD funcionando no necesitan nada**; los demás crean su `appsettings.local.json` desde la plantilla.

## Pendientes

- Propietario: confirmar con su BD 2008 real (compat 100) el flujo completo
- Fase 1: tenant context JWT (el `GimnasioId` sigue viniendo del DTO)
