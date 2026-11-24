# Módulo 10 — Extensiones por gimnasio (transversal)

## Propósito
Mecanismos para que cada gimnasio tenga sus propios **campos de datos, reglas y lógicas** sin modificar el núcleo inmutable. Definido en [`../../dominio/02-extension-por-gimnasio.md`](../../dominio/02-extension-por-gimnasio.md).

## Tablas (propuesta — requiere ADR y aprobación)
- `CampoExtendido` (GimnasioId, Tabla, RegistroId, Clave, Valor, TipoDato) — campos extra por registro
- `DefinicionCampoExtendido` (catálogo de campos por gimnasio y tabla, para UI dinámica)

## Ya existentes (no requieren nada nuevo)
- `ParametroConfiguracion` (clave/valor/tipo) — reglas Nivel 1
- `ConfiguracionGeneral` / `ConfiguracionMembresium` / `PoliticaGimnasio` — toggles por gimnasio

## Alcance MVP (transversal)
- Fase 0–1: solo Nivel 1 (parámetros existentes)
- Fase 2+: Nivel 2 (tabla `CampoExtendido`) cuando el primer gimnasio pida campos propios
- Nivel 3 (estrategias de código por tenant) bajo demanda con feature flags

## Reglas
- Nunca modificar tablas del núcleo por un solo gimnasio
- Los campos extendidos siempre llevan `GimnasioId` + unicidad `(GimnasioId, Tabla, RegistroId, Clave)`
- La UI renderiza los campos definidos en `DefinicionCampoExtendido` dinámicamente
