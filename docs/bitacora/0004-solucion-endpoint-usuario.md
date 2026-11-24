# 0004 — Solución: endpoint de creación de usuario y mapper

- **Fecha:** 2026-11-24
- **Repo:** Gimnasio · rama `fix/usuario-endpoint` (desde `desarrollo`)
- **Estado:** en revisión

## Qué

Corrección del único endpoint implementado (`POST api/Usuario`), que fallaba con HTTP 500 (ver hallazgo de [`0003-entorno-verificacion.md`](0003-entorno-verificacion.md)), y de los 87 warnings del mapper Mapperly.

## Causa raíz

| Problema | Causa |
|---|---|
| HTTP 500 al crear usuario | El repositorio insertaba un modelo con solo `Nombre`: sin `GimnasioId` (FK obligatoria de tenancy) y sin campos NOT NULL (`Correo`, `TipoAutenticacion`, `FechaCreacion`) |
| Mapper vacío (RMG012/RMG020 ×87) | La entidad de dominio (`IdUsuario`, solo `Nombre`) no compartía **ningún** nombre de propiedad con el modelo de persistencia (`UsuarioId`, `GimnasioId`, …), así que Mapperly no mapeaba nada |
| Mapper sin usar | `UsuarioRepository` mapeaba a mano (incompleto) en vez de usar `UsuarioMapper`; además los métodos del mapper estaban invertidos (`ToModel` devolvía dominio, `ToDomain` devolvía persistencia) |
| Propiedad inexistente | `MapperAttribute.RequiredMapping` no existe en Mapperly 4.3.1 → el nombre correcto es **`RequiredMappingStrategy`** (verificado contra el XML doc del paquete instalado) |

## Solución

1. **Entidad de dominio `Usuario`** alineada con el modelo de persistencia (`UsuarioId`, `GimnasioId`, `Nombre`, `ApellidoPaterno`, `Correo`, `TipoAutenticacion`, `Activo`, fechas): setters públicos (Mapperly no accede a setters privados desde otra clase) + **constructor con validación** que mantiene el estilo DDD que inició el dueño (rechaza nombre/apellido/correo vacíos y `GimnasioId <= 0`, fija `Activo = true` y `FechaCreacion = UtcNow`).
2. **`UsuarioMapper`** corregido: métodos con nombres claros (`ToPersistence` / `ToDomain`) y `RequiredMappingStrategy.None` (los miembros sin correspondencia —`Version`, `PasswordHash`, navegaciones— se dejan intencionalmente sin mapear; los de negocio se mapean solos por nombre).
3. **`UsuarioRepository`** ahora usa el mapper vía DI (registrado como singleton en `Infrastructure/DependencyInjection`).
4. **`CrearUsuarioDto`** completado (`GimnasioId`, apellidos, correo, teléfono, tipo de autenticación), documentando que `GimnasioId` es temporal hasta el tenant context por JWT de Fase 1.
5. **`UsuarioService`** construye la entidad por constructor y traduce excepciones de validación a `ResultadoDto { Exitoso = false }`.

## Verificación end-to-end (BD `Gimnasio_Dev`, SQL Server 2022)

| Prueba | Resultado |
|---|---|
| `POST api/Usuario` con datos completos (GimnasioId=1 sembrado) | ✅ HTTP 200 `{"exitoso":true}` |
| Fila en SQL Server | ✅ Usuario `#2 Ana Garcia` con todos los campos; `Version` rowversion generada por el motor (8 bytes) |
| Validación (nombre vacío) | ✅ HTTP 200 `{"exitoso":false,"mensaje":"El nombre es obligatorio..."}` |
| Compilación | ✅ **0 errores, 0 warnings** (antes: 87) |

## Impacto en BD / dominio

- Ningún cambio de esquema (solo capas de código).
- La alineación de nombres dominio↔persistencia queda como **convención** para las próximas entidades (registrar en estándares si el dueño lo aprueba).

## Pendientes

- `GimnasioId` sigue llegando en el DTO: sustituir por `ITenantContext` (JWT) al implementar Fase 1 (ver [`../dominio/03-multi-tenancy.md`](../dominio/03-multi-tenancy.md)).
- Añadir unicidad de correo por gimnasio (índice filtrado) cuando se activen migraciones de EF.
