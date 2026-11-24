# 🏢 Modelo multi-tenant — estado actual y decisiones

## Estado actual (detectado en `desarrollo`)

| Aspecto | Estado |
|---|---|
| Estrategia de datos | ✅ **BD compartida con discriminador**: columna `GimnasioId` en todas las tablas de negocio + catálogo `CatGimnasio` |
| Nomenclatura | La BD de pruebas se llama `Gimnasio_Tenant_Pruebas` y existe carpeta vacía `Infrastructure/Tenancy/` → la intención multi-tenant es explícita |
| Enforcement en código | ❌ **Ninguno**: `GimnasioDbContext` no tiene `HasQueryFilter`; los repositorios actuales no filtran por tenant |
| Resolución del tenant | ❌ No existe aún (no hay middleware ni claim JWT) |

## Riesgo actual

Con la configuración presente, **cualquier consulta puede leer datos de cualquier gimnasio**. El patrón está en el esquema pero no está protegido: es la corrección más urgente del backend (Fase 0 del roadmap).

## Decisión recomendada: mantener BD compartida + enforzar en el DbContext

### 1. Servicio de contexto de tenant

```csharp
public interface ITenantContext { int GimnasioId { get; } }

// Implementación: lee el claim "gimnasioId" del JWT del usuario autenticado
// y lo cachea por request (Scoped).
```

### 2. Filtro global de consultas (Una vez por entidad, en el DbContext)

```csharp
// En OnModelCreating, para cada entidad con GimnasioId:
entity.HasQueryFilter(e => e.GimnasioId == _tenantContext.GimnasioId);
```

Con esto **ninguna consulta puede cruzar gimnasios** aunque el desarrollador lo olvide. Para reportes globales se usa `IgnoreQueryFilters()` de forma explícita y auditada.

### 3. Índices y unicidad por tenant

- Todo índice inicia por `GimnasioId`: `IX_Socio_Gimnasio_Apellido (GimnasioId, ApellidoPaterno)`
- Unicidad relativa al gimnasio: `Usuario (GimnasioId, Correo)`, `CatGimnasio (Codigo)`

### 4. Guardas en escritura

Antes de `SaveChanges`, validar que toda entidad nueva tenga el `GimnasioId` del token (interceptor de EF). Rechazar discrepancias con excepción.

## Alternativas evaluadas

| Alternativa | Veredicto |
|---|---|
| **BD por gimnasio** (`Gimnasio_ClienteA`, `Gimnasio_ClienteB`) | Aislamiento total, pero multiplica migraciones, backups y despliegues; sobredimensionado para el MVP |
| **Esquema por gimnasio** (schema-per-tenant en una BD) | Mejor aislamiento que discriminador, peor operación que uno solo; migraciones por schema. Posible evolución futura |
| **BD compartida + `GimnasioId` (actual)** | ✅ Elegida: una sola infraestructura, filtros a nivel ORM, compatible con el esquema ya creado |

## Pendientes de implementación (tras aprobación del dueño)

1. `ITenantContext` + middleware de resolución por JWT
2. `HasQueryFilter` en las ~70 entidades con `GimnasioId`
3. Interceptor de `GimnasioId` en inserciones
4. Migración de índices compuestos por tenant
5. Tests que demuestren aislamiento entre dos gimnasios de prueba
