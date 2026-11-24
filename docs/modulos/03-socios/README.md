# Módulo 03 — Socios

## Propósito
El cliente del gimnasio: registro, datos personales, documentos, evaluaciones físicas, visitas y accesos.

## Tablas (10)
`Socio` · `SaldoSocio` · `VisitaSocio` · `AccesoSocio` · `Documento` · `CategoriaDocumento` · `EvaluacionFisica` · `ObjetivoFisico` · `HistorialObjetivoFisico` · `IncidenciaOperativa`

## Relaciones clave
- `Socio` N—1 `CatGimnasio` · `Socio` N—1 `Sucursal` (sucursal de registro)
- `Socio` 1—N `MembresiaSocio` / `VisitaSocio` / `AccesoSocio` / `Documento` / `EvaluacionFisica` / `SaldoSocio` / `RutinaSocio`
- `Socio` 1—N `ObjetivoFisico` + historial de cambios

## Alcance MVP (Fase 1)
- Registro de socio con datos obligatorios que ya existen: nombre, apellidos, `FechaNacimiento`, `Sexo`, contacto de emergencia (obligatorios en el modelo)
- Búsqueda/filtrado por gimnasio (nombre, apellido, correo, teléfono)
- Ficha del socio: membresía activa, saldo, últimas visitas
- Check-in (`AccesoSocio`) y bitácora de visitas

## Estado
Solo modelo de datos.

## Preguntas abiertas
- ¿Fotografía del socio en el MVP (URL ya existe en el modelo)?
- ¿Huella/RFID para accesos? (sugerido como campo extendido, ver módulo 10)
