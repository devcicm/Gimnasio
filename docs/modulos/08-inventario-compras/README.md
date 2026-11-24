# Módulo 08 — Inventario y compras

## Propósito
Catálogo de productos, stock por sucursal, movimientos/traspasos entre locales y ciclo de compras a proveedores.

## Tablas (12)
`Producto` · `CategoriaProducto` · `Marca` · `UnidadMedidum` · `InventarioSucursal` · `MovimientoInventario` · `TraspasoInventario` · `DetalleTraspasoInventario` · `Proveedor` · `ProductoProveedor` · `CompraProveedor` · `DetalleCompraProveedor`

## Relaciones clave
- `Producto` N—1 `CategoriaProducto` · N—1 `Marca` · N—1 `UnidadMedidum` · N—M `Proveedor` (ProductoProveedor)
- `InventarioSucursal`: stock actual por producto y sucursal
- `MovimientoInventario`: toda entrada/salida trazable (venta, compra, merma, traspaso)
- `TraspasoInventario` 1—N `DetalleTraspasoInventario` (sucursal origen → destino)
- `CompraProveedor` 1—N `DetalleCompraProveedor`

## Alcance MVP (Fase 3)
- CRUD de productos con stock inicial por sucursal
- Descontar stock al vender (integración con módulo 07) y al comprar (entrada)
- Traspaso simple entre sucursales del mismo gimnasio
- Alerta de stock mínimo (parámetro por gimnasio)

## Estado
Solo modelo de datos.

## Preguntas abiertas
- ¿Códigos de barras / escáner en el MVP?
- ¿Costeo promedio ponderado o último costo?
