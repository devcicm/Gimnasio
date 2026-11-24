# 🔄 Migración de SQL Server 2008 → versión actual

## El problema

Existe una copia de la base de datos legacy en **SQL Server 2008**. El backend usa **EF Core 8** con proveedor `Microsoft.EntityFrameworkCore.SqlServer 8.0.34`, que **oficialmente soporta SQL Server 2012 o superior**. Además, EF Core 8 genera `OPENJSON` en consultas con `Contains` (recomendado nivel de compatibilidad **≥130**, SQL Server 2016+) — configurable hacia abajo, pero no hasta 100 (2008).

**Conclusión técnica**: no se puede "habilitar compatibilidad nativa" con 2008 y usar EF Core 8. La BD debe migrarse a un motor moderno; la compatibilidad se usa como **puente controlado**, no como destino.

## Decisión recomendada

> **Restaurar/migrar la BD 2008 sobre SQL Server 2022 Express (gratis) y subir el nivel de compatibilidad por pasos: 100 → 130 → 160**, validando la aplicación en cada paso.

| Motor destino | Licencia | Compat. final | Motivo |
|---|---|---|---|
| **SQL Server 2022 Express** ✅ | Gratis (10 GB por BD, suficiente para MVP) | **160** | Motor actual con soporte hasta 2033; mismo dialecto que la API ya usa |

*(Azure SQL es alternativa válida si el dueño quiere nube desde el inicio; el código no cambia.)*

## Plan de migración (por pasos)

### Paso 0 — Respaldo y diagnóstico
- Copia `.bak` de la BD 2008 + script completo de esquema (`SSMS → Tareas → Generar scripts`).
- `DBCC CHECKDB` en la copia antes de mover nada.

### Paso 1 — Mover la BD al motor nuevo
- **Ruta A (preferida)**: `RESTORE DATABASE` del `.bak` 2008 directamente en SQL Server 2022. El restore **actualiza internamente** la BD.
- **Ruta B (si A falla)**: generar scripts de esquema+datos con compatibilidad "SQL Server 2022" y ejecutarlos en la instancia nueva.
- La BD queda en **nivel de compatibilidad 100** (2008): el motor la ejecuta, pero sin features nuevas.

### Paso 2 — Compatibilidad 100 → 130 (mínimo operativo para EF Core 8)
```sql
ALTER DATABASE [Gimnasio_Tenant_Pruebas] SET COMPATIBILITY_LEVEL = 130;
```
- Habilita `OPENJSON` (lo que EF Core 8 usa en `Contains`).
- Ejecutar suite de pruebas de la API. Si algo falla por `query optimizer`, usar `USE HINT('ENABLE_QUERY_OPTIMIZER_FIXES')` puntual antes de subir más.

### Paso 3 — Configurar EF Core (opcional pero recomendado)
```csharp
options.UseSqlServer(cs, o => o.UseCompatibilityLevel(130));
```
Así el SQL que genera EF respeta el nivel real de la BD.

### Paso 4 — Compatibilidad 130 → 160 (objetivo final)
- Regresión completa (API + consultas críticas de reportes).
- `ALTER DATABASE … SET COMPATIBILITY_LEVEL = 160;`
- Dejar `UseCompatibilityLevel(160)` en `DependencyInjection.cs`.

### Paso 5 — Modernización posterior (no bloquea el MVP)
- `DATETIME` → `DATETIME2`, `TEXT/IMAGE` → `NVARCHAR(MAX)/VARBINARY(MAX)` si existen
- Índices compuestos por tenant (ver estándares)
- Activar migraciones de EF Core sobre la BD migrada

## Qué NO hacer

- ❌ Quedarse en compatibilidad 100 "porque funciona": EF Core 8 fallará silenciosamente en rutas con `Contains`
- ❌ Instalar el motor 2008 en producción nueva: **sin soporte desde julio 2019** (riesgo de seguridad)
- ❌ Migrar sin copia verificada con `DBCC CHECKDB`

## Lo que necesito para avanzar

1. El archivo **`.bak`** de la BD (o el script de esquema), copiado por ejemplo en `B:\GYM\legacy-db\`
2. Confirmar si la máquina destino tiene (o puede instalar) **SQL Server 2022 Express**
3. Con el `.bak` restaurado haré: inventario exacto de tablas/campos/datos reales ↔ comparación contra los 76 modelos de EF Core ↔ reporte de diferencias y plan de seed
