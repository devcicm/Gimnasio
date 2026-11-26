# 🔄 Retrocompatibilidad de entornos — stack viejo y stack nuevo con el mismo código

> Objetivo: que **el mismo código** funcione tanto en el entorno del propietario (stack con SQL Server 2008, que **no se va a actualizar**) como en entornos con stack actualizado (SQL Server 2022), sin valores hardcodeados por máquina.

## 1. Cómo se resuelve la configuración (sin hardcodear nada)

Ningún archivo versionado contiene nombres de servidor, instancias ni bases de datos específicas de una máquina. El orden de precedencia de la configuración es:

```
1. Variables de entorno           →  ConnectionStrings__GimnasioConnection, Database__CompatibilityLevel
2. appsettings.local.json         →  POR MÁQUINA, NO SE VERSIONA (en .gitignore)
3. appsettings.Development.json   →  valores de desarrollo compartidos
4. appsettings.json               →  valores neutros por defecto (localhost)
```

Para crear tu configuración local, copia la plantilla y edítala (queda fuera de git):

```powershell
copy Gimnasio.API\appsettings.local.example.json Gimnasio.API\appsettings.local.json
# luego edítala con los datos de TU máquina
```

### Claves de configuración

| Clave | Para qué | Valores |
|---|---|---|
| `ConnectionStrings:GimnasioConnection` | Cadena de conexión a SQL Server | Cada máquina la suya (ver ejemplos abajo) |
| `Database:CompatibilityLevel` | SQL que genera EF Core | `100`=2008/R2 · `110`=2012 · `120`=2014 · `130`=2016 · `140`=2017 · `150`=2019 · `160`=2022 (defecto) |

El valor resuelto se imprime al arrancar la API:
`[Infrastructure] SQL Server CompatibilityLevel EF: <nivel>` — así siempre sabes qué modo está corriendo.

## 2. ¿Qué cambia realmente con el nivel de compatibilidad?

EF Core 8 ajusta el SQL que genera según el nivel configurado, **sin cambiar una línea de código**:

| Nivel | SQL de paginación (`Skip/Take`) | SQL de `Contains` con listas |
|---|---|---|
| ≥ 130 | `OFFSET / FETCH` | `OPENJSON` (moderno) |
| < 130 | `OFFSET / FETCH` | `IN (@p1, @p2, ...)` (clásico) |
| < 110 | `ROW_NUMBER() OVER (...)` (compatible 2008) | `IN (@p1, @p2, ...)` |

Esto resuelve el error del propietario: con `CompatibilityLevel: 100`, EF deja de generar `OPENJSON` y `OFFSET/FETCH` (que no existen en SQL Server 2008).

> ⚠️ Nota honesta: el proveedor oficial de EF Core 8 declara soporte desde SQL Server 2012. El nivel 100 funciona para los patrones que usa este código (CRUD con EF) porque EF genera SQL legacy, pero es compatibilidad de facto: conviene probar el flujo completo contra la BD 2008 real antes de confiar en producción.

## 3. Receta por entorno

### 🖥️ Propietario (stack viejo — SQL Server 2008)

1. Crear `Gimnasio.API/appsettings.local.json` (no se sube al repo):

```json
{
  "ConnectionStrings": {
    "GimnasioConnection": "Server=.\\SQLEXPRESS;Database=Gimnasio_Tenant_Pruebas;Trusted_Connection=True;TrustServerCertificate=True"
  },
  "Database": {
    "CompatibilityLevel": 100
  }
}
```

*(usar el nombre de servidor/instancia real de tu máquina; `ALEJANDRO\SQLEXPRESS` también vale si es tu PC)*

2. Arrancar normal: `dotnet run --project Gimnasio.API`
3. Verificar en la consola: `[Infrastructure] SQL Server CompatibilityLevel EF: 100`
4. **No ejecutar** la herramienta `DbInit` contra tu base: es solo para crear una BD de desarrollo desde cero en máquinas sin BD (`EnsureCreated`). Si la BD ya existe, no hace nada, pero por convenio no se usa fuera de entornos nuevos.

### 💻 Colaboradores / servidores (stack nuevo — SQL Server 2016..2022)

1. Usar el default (`localhost`, nivel 160) o crear tu `appsettings.local.json`.
2. Si quieres partir desde la BD legacy real: restaurar el `.bak` 2008 en SQL Server 2022 y subir compatibilidad por pasos — ver [`01-migracion-sql-server-2008.md`](01-migracion-sql-server-2008.md).
3. **Versión vieja en entorno nuevo**: la BD 2008 restaurada en un motor moderno funciona con niveles de compatibilidad intermedios (100 → 130 → 160) según el plan del documento de migración.

## 4. Sobre los errores del IDE (subrayados rojos en el mapper)

Si el IDE marca en rojo `ToPersistence` / `ToDomain` de `UsuarioMapper` (métodos `partial` sin cuerpo visible):

- **Es normal sin compilar**: los cuerpos los genera el *source generator* de Mapperly (`Riok.Mapperly` 4.3.1, versión fijada en el `.csproj`) durante el build.
- Ejecutar `dotnet build Gimnasio.API\Gimnasio.sln` y los errores del IDE desaparecen al refrescar.
- Requisito: **.NET 8 SDK** (el proyecto es `net8.0`). Verificar con `dotnet --list-sdks`.
- La corrección en runtime está probada: `POST api/Usuario` devuelve 200 con inserción real verificada en BD (bitácora 0004).

## 5. Política anti-hardcode

| Antes (hardcodeado) | Ahora |
|---|---|
| `Server=ALEJANDRO\SQLEXPRESS` en `appsettings.json` | Default neutro `localhost` + `appsettings.local.json` por máquina |
| BD fija `Gimnasio_Tenant_Pruebas` | Cada entorno define la suya (dev: `Gimnasio_Dev`) |
| Nivel de compatibilidad implícito del driver (160, rompía en SQL 2008) | `Database:CompatibilityLevel` configurable por entorno |
| Herramienta DbInit con conexión fija | Acepta argumento o variable de entorno `GIMNASIO_DB_CONNECTION` |
| URLs/puertos fijados en scripts | `--urls` al arrancar (scripts en `tools/`) |

**Regla**: al repo nunca se sube el nombre de una máquina, instancia ni base de datos real.
