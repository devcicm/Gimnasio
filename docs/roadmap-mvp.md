# 🗺️ Roadmap MVP — prioridad base de datos y dominio

> Objetivo: un MVP funcional cuyo corazón sea una **base de datos sólida, inmutable en su núcleo y extensible por gimnasio**.

## Fase 0 — Fundaciones de BD *(prioridad máxima, bloquea todo)*

1. **Migrar la BD legacy (SQL Server 2008) a SQL Server 2022** — ver [`base-datos/01-migracion-sql-server-2008.md`](base-datos/01-migracion-sql-server-2008.md). Sin esto, EF Core 8 no puede operar.
2. Definir nivel de compatibilidad final y validar el esquema contra los modelos de EF Core.
3. Activar **migraciones de EF Core** versionadas en el repo (hoy la BD se gestiona a mano).
4. **Enforzar multi-tenancy en el DbContext**: filtros globales (`HasQueryFilter`) por `GimnasioId` — ver [`dominio/03-multi-tenancy.md`](dominio/03-multi-tenancy.md).
5. Datos semilla (seed) de catálogos: `DiaSemana`, `MetodoPago`, `TipoNotificacion`, `TipoClase`, `UnidadMedida`, `GrupoMuscular`.

## Fase 1 — Núcleo inmutable funcionando *(backend)*

Módulos: **Seguridad-Usuarios**, **Socios**, **Membresías** (ver [`modulos/`](modulos/README.md)).

- Endpoints CRUD siguiendo el patrón existente (Controller → Service → Repository → UnitOfWork).
- Autenticación (JWT) y autorización por `Rol`/`Permiso`.
- Registro de socio + contratación de membresía + generación de pago.

## Fase 2 — Operación diaria del gimnasio

Módulos: **Clases y Horarios**, **Accesos y Asistencias**, **Rutinas**.

- Reservaciones, listas de espera, check-in por acceso.
- Rutinas por socio con ejercicios y seguimiento.

## Fase 3 — ERP (dinero e inventario)

Módulos: **Ventas y Caja**, **Inventario y Compras**.

- Punto de venta, movimientos de caja, cortes.
- Compras a proveedores, traspasos entre sucursales.

## Fase 4 — Comunicación y configuración avanzada

Módulos: **Comunicaciones**, **Configuración por gimnasio**.

- Comunicados, notificaciones con plantillas.
- Parametrización completa por tenant (reglas, campos extendidos).

## Frontend (paralelo por fase)

Cada fase de backend se refleja en `Gimnasio.UI` (Angular) con sus features: login → panel de socios → clases → caja. La landing page ya aportada (PR #1) no depende de la API.

## Criterio de "MVP terminado"

Un gimnasio puede: crear usuarios con roles, registrar socios, vender membresías, cobrar en caja, controlar accesos y reservar clases — todo filtrado por su propio `GimnasioId`, sin afectar a otros gimnasios.
