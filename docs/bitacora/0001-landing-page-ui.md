# 0001 — Landing page del gimnasio (frontend)

- **Fecha:** 2026-11-23
- **Repo:** [Gimnasio.UI](https://github.com/Developer-net-web/Gimnasio.UI) · rama `feature/landing-page` · [PR #1](https://github.com/Developer-net-web/Gimnasio.UI/pull/1)
- **Estado:** abierta, esperando revisión del dueño

## Qué

Landing page completa, responsive y en español que reemplaza la plantilla placeholder de Angular: navbar con menú móvil, hero, clases, planes, horarios, contacto y footer.

## Por qué

El proyecto estaba recién inicializado (1 commit con la plantilla de Angular CLI). Una página de presentación es el primer entregable visible y sirve de base visual para el resto de la UI.

## Impacto en BD / dominio

Ninguno. Contenido estático centralizado en `src/app/features/landing/landing-data.ts`, listo para consumir la API en el futuro (las entidades `Clase`, `PlanMembresium` y `HorarioClase` del backend coinciden con las secciones de la landing).

## Estructura creada

```
src/app/features/landing/
  landing.ts / landing.html
  landing-data.ts                ← contenido editable en un solo lugar
  sections/
    navbar/ hero/ clases/ planes/ horarios/ contacto/ footer/
```

## Verificación

- `ng build` sin errores ni warnings de budget · `ng test` 4/4 pasando
- Probado en desktop (1440px) y móvil (390px), sin errores de consola
- Capturas en `docs/screenshots/` del repo UI

## Pendientes

- Consumir clases/planes/horarios reales desde la API cuando existan los endpoints (Fase 1–2 del [roadmap](../roadmap-mvp.md))
- Definir marca y datos definitivos con el dueño
