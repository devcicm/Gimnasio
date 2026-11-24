# 🔌 Extensibilidad por gimnasio — campos, reglas y lógicas nuevas sin tocar el núcleo

> Problema: el gimnasio de un local distinto necesita **más reglas, más campos de datos y más lógicas de negocio**. Solución: tres niveles de extensión, en este orden de preferencia.

## Nivel 1 — Reglas por configuración (ya existe en el modelo)

El sistema ya lo prevé: **primero configurar, nunca programar**.

| Tabla | Uso |
|---|---|
| `ConfiguracionGeneral` | Toggles globales del gimnasio (ej. `PermitirVentaSinSocio`, `PermitirSaldoAfavor`) |
| `ParametroConfiguracion` | Clave/valor con `TipoDato` (ej. `Clave="TopeInvitadosMes"`, `Valor="3"`, `TipoDato="int"`) |
| `PoliticaGimnasio` | Textos/valores de política del gimnasio |

**Regla**: si una diferencia entre gimnasios se puede expresar como un número, un booleano o un texto → es un parámetro, no código nuevo. Las claves nuevas de `ParametroConfiguracion` **no requieren migración**.

## Nivel 2 — Campos de datos extendidos (propuesta)

Cuando un gimnasio necesita **guardar datos extra** que el núcleo no tiene (ej. "licencia médica", "número de casillero", "RFID de pulsera"):

### Tabla única de extensión (recomendada para el MVP)

```sql
CREATE TABLE CampoExtendido (
    CampoExtendidoId   INT IDENTITY PRIMARY KEY,
    GimnasioId         INT NOT NULL,          -- tenant
    Tabla              NVARCHAR(100) NOT NULL, -- ej. 'Socio', 'Producto'
    RegistroId         INT NOT NULL,           -- PK de la fila extendida
    Clave              NVARCHAR(100) NOT NULL,
    Valor              NVARCHAR(MAX) NULL,
    TipoDato           NVARCHAR(20)  NOT NULL, -- string|int|decimal|date|bool
    Activo             BIT NOT NULL DEFAULT 1,
    Version            ROWVERSION,
    CONSTRAINT UQ_CampoExtendido UNIQUE (GimnasioId, Tabla, RegistroId, Clave)
);
```

- **Pros**: un solo mecanismo para todas las tablas del núcleo, único por gimnasio+tabla+registro+clave, consultable e indexable.
- **Contras**: sin constraints de tipo fuertes; se valida en capa de aplicación.
- Catálogo opcional `DefinicionCampoExtendido (GimnasioId, Tabla, Clave, TipoDato, Requerido, Etiqueta)` para que cada gimnasio **defina sus propios formularios** (la UI los renderiza dinámicamente).

### Alternativa descartada para el MVP: columna JSON por tabla
Requiere nivel de compatibilidad ≥130 (SQL Server 2016) y complica queries/filtros. Reevaluable tras la migración si el volumen de campos extendidos crece mucho.

## Nivel 3 — Lógicas de negocio por gimnasio (código)

Cuando la diferencia es **comportamiento** (ej. "el acceso se bloquea si hay 3 mensualidades vencidas", solo para un cliente):

1. **Feature flags** en `ParametroConfiguracion` → el código decide con estrategia:
   ```csharp
   IReglaAcceso regla = reglas.ObtenerPara(gimnasioId); // default o override por tenant
   ```
2. **Interfaz por regla + implementación default** en Application; overrides registrados en DI condicionados al tenant.
3. Si la lógica es grande y exclusiva de un cliente → **módulo nuevo** (carpeta `Features/<Modulo>/`), nunca parche sobre otro módulo.

## Lo que jamás se hace

- ❌ Añadir columnas al núcleo por pedido de un solo gimnasio
- ❌ `ALTER TABLE` fuera de una migración de EF Core
- ❌ Lógica de un tenant filtrando datos de otro
- ❌ Duplicar tablas base "para el cliente X"

## Árbol de decisión

```
¿Necesidad nueva de un gimnasio?
├─ ¿Se expresa como valor/booleano/texto?      → Nivel 1: ParametroConfiguracion
├─ ¿Son datos extra que hay que guardar?        → Nivel 2: CampoExtendido
├─ ¿Es un comportamiento distinto?              → Nivel 3: feature flag / estrategia
└─ ¿Es un módulo de negocio completo que falta? → nuevo módulo en Features/ (+ ADR)
```
