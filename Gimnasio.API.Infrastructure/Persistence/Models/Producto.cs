using System;
using System.Collections.Generic;

namespace Gimnasio.API.Infrastructure.Persistence.Models;

public partial class Producto
{
    public int ProductoId { get; set; }

    public int GimnasioId { get; set; }

    public int CategoriaProductoId { get; set; }

    public int? MarcaId { get; set; }

    public int UnidadMedidaId { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Sku { get; set; }

    public string? CodigoBarras { get; set; }

    public string? Descripcion { get; set; }

    public decimal PrecioCompra { get; set; }

    public decimal PrecioVenta { get; set; }

    public decimal PorcentajeImpuesto { get; set; }

    public bool ControlarInventario { get; set; }

    public decimal StockMinimo { get; set; }

    public string? ImagenUrl { get; set; }

    public bool Activo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public byte[] Version { get; set; } = null!;

    public virtual CategoriaProducto CategoriaProducto { get; set; } = null!;

    public virtual ICollection<DetalleCompraProveedor> DetalleCompraProveedors { get; set; } = new List<DetalleCompraProveedor>();

    public virtual ICollection<DetalleTraspasoInventario> DetalleTraspasoInventarios { get; set; } = new List<DetalleTraspasoInventario>();

    public virtual CatGimnasio Gimnasio { get; set; } = null!;

    public virtual ICollection<InventarioSucursal> InventarioSucursals { get; set; } = new List<InventarioSucursal>();

    public virtual Marca? Marca { get; set; }

    public virtual ICollection<MovimientoInventario> MovimientoInventarios { get; set; } = new List<MovimientoInventario>();

    public virtual ICollection<ProductoProveedor> ProductoProveedors { get; set; } = new List<ProductoProveedor>();

    public virtual UnidadMedidum UnidadMedidum { get; set; } = null!;
}
