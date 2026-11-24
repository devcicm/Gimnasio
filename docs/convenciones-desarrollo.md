# 🛠️ Convenciones de desarrollo

## Flujo de ramas (respetando el flujo del repo)

```
feature/<nombre>  ──PR──►  desarrollo  ──►  qa  ──►  produccion  ──►  master
```

- Toda implementación nueva nace de `desarrollo` en una rama `feature/<modulo>-<tema>`.
- Los PRs se dirigen a **`desarrollo`**.
- Un PR = una implementación = una entrada en la bitácora.

## Estructura de módulos y features

Cada implementación vive en una carpeta de módulo, tanto en código como en documentación.

### En código (backend .NET)

Se conserva la arquitectura limpia existente y se organizan las implementaciones por módulo:

```
Gimnasio.API.Application/
  Features/
    <Modulo>/                    ← ej. Socios, Membresias, Clases, Seguridad
      Dtos/
      Interfaces/
      Services/
Gimnasio.API.Infrastructure/
  Features/
    <Modulo>/
      Repositories/
      Mappers/
```

Reglas:
- Un módulo = un bounded context del dominio (ver [`modulos/`](modulos/README.md)).
- Los servicios y repositorios **nunca cruzan módulos directamente**; se comunican por interfaces de aplicación.
- Los DTOs nunca exponen entidades de persistencia.

### En documentación

```
docs/
  bitacora/NNNN-<nombre>.md        ← 1 entrada por implementación
  dominio/…                        ← cambios de dominio requieren ADR
  modulos/<modulo>/README.md       ← alcance, tablas y decisiones del módulo
```

## Bitácora

Cada implementación registrada en `docs/bitacora/NNNN-<nombre>.md` con:

1. **Qué** se implementó
2. **Dónde** (repo, rama, PR)
3. **Por qué** (motivo / problema que resuelve)
4. **Impacto en BD/dominio** (tablas nuevas, campos, migraciones)
5. **Pendientes**

## Cambios al dominio

Cualquier cambio sobre el núcleo inmutable (ver [`dominio/01-nucleo-inmutable.md`](dominio/01-nucleo-inmutable.md)) requiere:

1. Un ADR en `docs/dominio/adr/NNNN-<decision>.md`
2. Migración de EF Core versionada (nunca editar la BD a mano)
3. Aprobación del dueño del repo en el PR
