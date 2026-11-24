# Módulo 09 — Comunicaciones

## Propósito
Comunicados internos, notificaciones del sistema a socios/usuarios y plantillas de mensajes.

## Tablas (7)
`Comunicado` · `ComunicadoLectura` · `Notificacion` · `NotificacionLectura` · `PlantillaNotificacion` · `TipoNotificacion` · `HistorialNotificacion`

## Relaciones clave
- `Comunicado` N—1 `Usuario` (autor) · N—1 `CatGimnasio` · 1—N `ComunicadoLectura` (quién lo leyó)
- `Notificacion` → destinatario (socio o usuario) · 1—N `NotificacionLectura`
- `PlantillaNotificacion` por `TipoNotificacion` (ej. "membresía por vencer", "bienvenida") — cuerpo con variables

## Alcance MVP (Fase 4)
- Comunicados internos con acuse de lectura
- Notificación automática de membresía por vencer usando `PlantillaNotificacion`
- Centro de notificaciones en la UI (bandeja por usuario/socio)

## Estado
Solo modelo de datos.

## Preguntas abiertas
- ¿Canal del MVP: solo in-app o también email/WhatsApp?
- ¿Proveedor externo de envío (SendGrid/Twilio) — costo por tenant?
