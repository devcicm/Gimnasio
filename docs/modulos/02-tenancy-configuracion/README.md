# Módulo 02 — Tenancy y configuración

## Propósito
Registrar gimnasios (tenants), sus sucursales y toda la configuración que permite que cada local tenga sus propias reglas sin tocar el núcleo.

## Tablas (10)
`CatGimnasio` · `Sucursal` · `PerfilGimnasio` · `PoliticaGimnasio` · `ConfiguracionGeneral` · `ConfiguracionMembresium` · `ParametroConfiguracion` · `HorarioSucursal` · `ExcepcionHorarioSucursal` · `DiaSemana`

## Relaciones clave
- `CatGimnasio` 1—N `Sucursal` · `CatGimnasio` 1—1 `ConfiguracionGeneral` / `ConfiguracionMembresium` / `PerfilGimnasio`
- `ParametroConfiguracion`: clave/valor/tipo por gimnasio (mecanismo Nivel 1 de extensión)
- `HorarioSucursal` + `ExcepcionHorarioSucursal` sobre `DiaSemana`

## Alcance MVP (Fase 0–1)
- Alta de gimnasio con su código único (`CatGimnasio.Codigo`) y sucursal principal
- Filtros globales de tenant (`HasQueryFilter`) en el DbContext
- Seed de `DiaSemana`
- CRUD de configuración general y parámetros por gimnasio

## Estado
Solo modelo de datos. Sin endpoints. Es el primer bloque del roadmap (Fase 0).

## Preguntas abiertas
- ¿Quién crea gimnasios nuevos (superadmin) y cómo se cobran/activan?
- ¿`Sucursal` única por gimnasio en el MVP o siempre multi-sucursal?
