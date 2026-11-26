# 🌅 Contexto y trasfondo del proyecto

> Este documento explica **qué es este proyecto, para qué existe, quién participa, cómo empezó esta etapa y por qué se tomaron las decisiones** — escrito para que cualquier persona (técnica o no) pueda entenderlo sin conocer nada previo.

---

## 1. El problema real: administrar un gimnasio es administrar un negocio

Un gimnasio, visto como negocio, hace muchas cosas al mismo tiempo:

- **Registra socios** (los clientes): sus datos, contactos de emergencia, fotos, documentos, evaluaciones físicas.
- **Vende membresías**: planes mensuales, trimestrales o anuales; renovaciones; pagos con distintos métodos; saldos a favor.
- **Controla quién entra**: validando que la membresía esté vigente, registrando visitas y accesos.
- **Ofrece clases**: spinning, crossfit, yoga, boxeo… con horarios, instructores, cupos, reservaciones y listas de espera.
- **Diseña rutinas de entrenamiento** por socio, con ejercicios y seguimiento del progreso.
- **Vende productos** (proteínas, bebidas, guantes), maneja **inventario**, **compra a proveedores** y **corta caja** al final del día.
- **Se comunica** con sus socios: avisos de membresía por vencer, comunicados, promociones.

Hacer esto en papel o con planillas dispersas genera errores, filas en recepción y decisiones a ciegas. Este proyecto construye el **sistema informático** que ordena toda esa operación en un solo lugar.

## 2. La idea distintiva: un solo sistema, muchos gimnasios

La decisión de diseño más importante del proyecto: el sistema **no es para un solo gimnasio**. Es una plataforma donde **cada gimnasio cliente ("tenant") opera con total independencia** dentro del mismo sistema:

- Cada gimnasio tiene su **código único**, sus **sucursales**, sus **planes y precios**, sus **reglas** (por ejemplo: "permitir venta sin socio: sí/no").
- **Los datos de un gimnasio jamás se mezclan con los de otro**: toda la información lleva una etiqueta interna (`GimnasioId`) que identifica a qué gimnasio pertenece.
- Si un gimnasio necesita **campos o reglas extra** que el sistema no trae, se agregan por **configuración y extensión**, sin modificar el corazón del sistema (ver [extensibilidad](dominio/02-extension-por-gimnasio.md)).

Esto se llama arquitectura **multi-tenant** (multi-inquilino): como un edificio donde cada negocio tiene su local, pero comparten la estructura del edificio.

## 3. ¿Qué existe hoy? ¿Y qué falta?

El proyecto está **al comienzo del camino**, pero con una base sólida:

| Pieza | Estado | Explicación sencilla |
|---|---|---|
| **Diseño de la base de datos** | ✅ Completo (76 tablas) | Toda la información del negocio ya está "moldeada": socios, membresías, clases, caja, inventario… |
| **API (backend)** | 🔨 Módulo 1 de 10 en funcionamiento | El "cerebro" que procesa y guarda datos; hoy registra usuarios, el resto se construye módulo a módulo |
| **Frontend** | ✅ Primera piedra puesta (landing pública) | La página web que ve el público; los paneles internos vienen después |
| **Plan de trabajo** | ✅ Definido (roadmap MVP) | El orden en que se construye todo, priorizando la base de datos |

La estrategia acordada es **"base de datos primero"**: un edificio se sostiene sobre sus cimientos. Antes de agregar pantallas y funciones, se asegura que la estructura de datos sea sólida, inmutable en su núcleo y extensible para cada gimnasio.

## 4. El stack tecnológico (en palabras simples)

| Capa | Tecnología | Qué hace |
|---|---|---|
| **Frontend** | Angular 22 (repo [`Gimnasio.UI`](https://github.com/Developer-net-web/Gimnasio.UI)) | Lo que se ve en el navegador: la web del gimnasio y, más adelante, los paneles internos |
| **Backend (API)** | .NET 8 con C# (este repo) | El "cerebro": recibe pedidos, aplica las reglas del negocio y guarda/consulta datos |
| **Base de datos** | SQL Server | El "almacén" donde vive toda la información |

## 5. Quién participa y cómo trabajamos

| Rol | Cuenta GitHub | Qué hace |
|---|---|---|
| **Propietario del proyecto** | [`Developer-net-web`](https://github.com/Developer-net-web) | Define el rumbo, revisa y aprueba cada cambio (PRs) |
| **Colaborador** | [`devcicm`](https://github.com/devcicm) | Propone implementaciones por medio de forks y pull requests |

**Flujo de trabajo:** nadie escribe directamente sobre el proyecto principal. Cada implementación se hace en una rama propia (`feature/...` o `fix/...`), se propone como **Pull Request (PR)** —una "solicitud de revisión"— y el propietario la aprueba. Los cambios fluyen por sus ramas: `desarrollo` → `qa` → `produccion` → `master`.

**Regla de oro del equipo:** *todo lo que se implementa se documenta* en la **bitácora** ([`docs/bitacora/`](bitacora/README.md)), que funciona como diario cronológico del proyecto: qué se hizo, dónde, por qué y qué quedó pendiente.

## 6. La historia de esta etapa (noviembre 2026)

1. **El propietario crea los dos repositorios**: `Gimnasio` (API) y `Gimnasio.UI` (frontend), con el proyecto recién inicializado y el modelo de datos ya modelado (76 tablas, fruto de su trabajo previo con su base de datos legacy en SQL Server 2008).
2. **El colaborador hace fork** de ambos y propone la primera implementación: la **landing page** del gimnasio ([PR #1 de Gimnasio.UI](https://github.com/Developer-net-web/Gimnasio.UI/pull/1)).
3. **Se decide priorizar la base de datos** para el MVP: se documenta el dominio completo, se detecta que el modelo ya es multi-tenant, se propone el roadmap ([PR #1 de Gimnasio](https://github.com/Developer-net-web/Gimnasio/pull/1)).
4. **Se prepara y verifica el entorno**: la API compila, arranca y guarda datos en una base de datos de desarrollo creada desde el modelo.
5. **Se corrige el primer endpoint** (`POST api/Usuario`), que fallaba por no asignar el gimnasio (tenant) y por un mapper sin configurar ([PR #2 de Gimnasio](https://github.com/Developer-net-web/Gimnasio/pull/2)).
6. **El propietario prueba y aparecen errores**: su base de datos es **SQL Server 2008** y no piensa actualizarla. La herramienta moderna (EF Core 8) generaba comandos que 2008 no entiende. Además, la configuración traía "hardcodeado" el nombre de la máquina del propietario, que no sirve en otras computadoras.
7. **Se resuelve con retrocompatibilidad**: ahora el nivel de compatibilidad de SQL es **configurable por entorno** — el propietario pone `100` (su SQL 2008) en un archivo local que no se sube al repositorio, y el mismo código funciona en su máquina y en cualquier otra ([PR #2, commits de retrocompatibilidad](base-datos/02-retrocompatibilidad-entornos.md)).

## 7. El desafío de los dos entornos (y su solución)

Cada persona trabaja en una computadora distinta, con versiones distintas:

| | Propietario | Colaborador / cualquier otro |
|---|---|---|
| Base de datos | **SQL Server 2008** (no va a cambiar) | SQL Server moderno (2016–2022) |
| Servidor local | Su instancia `SQLEXPRESS` | Otra instancia/servidor |
| Qué necesitan | El mismo código funcionando **sin cambios** | Poder montar el proyecto desde cero |

**La solución tiene tres partes:**

1. **Cero valores hardcodeados**: ningún archivo del repositorio menciona servidores, máquinas ni bases de datos reales. Cada quien configura la suya en un archivo local (`appsettings.local.json`) que no se sube a git, o con variables de entorno.
2. **Nivel de compatibilidad de SQL configurable**: con `CompatibilityLevel: 100`, la herramienta moderna "habla" el dialecto antiguo que SQL Server 2008 entiende; con `160` habla el moderno. El mismo código, dos dialectos.
3. **Documentación bidireccional**: cómo correr el *código nuevo* en el *entorno viejo* (nivel de compatibilidad) y cómo correr la *base vieja* en el *entorno nuevo* (restaurar y migrar por pasos — [guía de migración](base-datos/01-migracion-sql-server-2008.md)).

## 8. Los principios del proyecto

1. **Núcleo inmutable, borde extensible**: las tablas base del negocio no se alteran por pedido de un solo gimnasio; las necesidades nuevas se resuelven con configuración y extensión.
2. **Base de datos primero**: cimientos sólidos antes de construir pisos.
3. **Multi-tenant desde el día cero**: todo dato pertenece a un gimnasio; ningún dato se cruza entre gimnasios.
4. **Todo se documenta**: cada implementación entra a la bitácora con su PR.
5. **Cero hardcode**: lo específico de cada máquina nunca entra al repositorio.
6. **Compatibilidad hacia atrás**: el stack viejo del propietario es una restricción de primera clase, no un obstáculo a ignorar.

## 9. Glosario

**Términos del negocio**

| Término | Significado |
|---|---|
| **Socio** | El cliente del gimnasio: la persona inscrita que usa las instalaciones |
| **Membresía** | El contrato de servicio del socio: qué plan compró, desde y hasta cuándo |
| **Plan** | El catálogo de membresías que vende un gimnasio (mensual, trimestral…) con su precio |
| **Sucursal** | Cada local físico de un gimnasio (un gimnasio puede tener varias) |
| **Caja** | El dinero físico/electrónico que se maneja en recepción; se "corta" (concilia) al cerrar el día |
| **Check-in / acceso** | El registro de entrada del socio al gimnasio |
| **Rutina** | El plan de ejercicios asignado a un socio, día por día |

**Términos técnicos**

| Término | Significado |
|---|---|
| **API** | Interfaz de programación: el "cerebro" sin interfaz gráfica que procesa y guarda datos |
| **Tenant (inquilino)** | Cada gimnasio cliente dentro de la plataforma multi-tenant |
| **Multi-tenant** | Arquitectura donde un solo sistema atiende a muchos clientes con datos aislados entre sí |
| **`GimnasioId`** | La columna que etiqueta cada dato con el gimnasio al que pertenece |
| **EF Core** | Entity Framework Core: la herramienta que traduce entre objetos C# y tablas de SQL Server |
| **Nivel de compatibilidad** | "Dialecto" de SQL que usa un servidor; configurable para hablar con versiones viejas (2008) o nuevas (2022) |
| **Mapperly** | Generador de código que convierte automáticamente entre objetos internos (menos código repetido, menos errores) |
| **Source generator** | Programa que escribe código automáticamente durante la compilación (por eso el IDE puede "marcar" métodos sin cuerpo hasta compilar) |
| **PR (Pull Request)** | Propuesta de cambios que el propietario revisa antes de aceptar |
| **Bitácora** | El diario cronológico del proyecto: qué se hizo, dónde, por qué |
| **Hardcode** | Un valor fijo escrito en el código (ej. el nombre de una computadora) que rompe el proyecto en cualquier otro entorno |

## 10. ¿Por dónde seguir?

- Si quieres **entender el dominio**: [`dominio/00-modelo-actual.md`](dominio/00-modelo-actual.md) y [`dominio/01-nucleo-inmutable.md`](dominio/01-nucleo-inmutable.md)
- Si quieres **ejecutar el proyecto**: el [Inicio rápido del README](../README.md)
- Si quieres **contribuir**: [`convenciones-desarrollo.md`](convenciones-desarrollo.md) y el [`roadmap-mvp.md`](roadmap-mvp.md)
- Si quieres **ver qué se hizo y cuándo**: [`bitacora/`](bitacora/README.md)
