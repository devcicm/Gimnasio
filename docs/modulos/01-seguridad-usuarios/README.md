# Módulo 01 — Seguridad y usuarios

## Propósito
Autenticación y autorización de todo el sistema, acotadas por gimnasio (tenant).

## Tablas (6)
`Usuario` · `Rol` · `Permiso` · `RolPermiso` · `UsuarioRol` · `UsuarioSucursal`

## Relaciones clave
- `Usuario` N—1 `CatGimnasio` · `Usuario` N—M `Rol` (UsuarioRol) · `Rol` N—M `Permiso` (RolPermiso) · `Usuario` N—M `Sucursal` (UsuarioSucursal)
- `Usuario` 1—0..1 `Instructor` (un usuario puede ser instructor)

## Alcance MVP (Fase 1)
- Login con JWT (claim `gimnasioId` para el tenant context)
- CRUD de usuarios, roles y permisos por gimnasio
- `PasswordHash` + `TipoAutenticacion` ya existen en la tabla; definir política de contraseñas
- Registro de `UltimoAcceso`

## Estado
Único módulo con código implementado (`UsuarioController`, `UsuarioService`, `UsuarioRepository`). Falta: JWT, roles/permisos en endpoints, filtro de tenant.

## Preguntas abiertas
- ¿Superusuario global para administración de tenants (creación de gimnasios)?
- ¿Refresh tokens / recuperación de contraseña en el MVP?
