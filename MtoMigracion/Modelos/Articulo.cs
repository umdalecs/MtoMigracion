#nullable enable

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace MtoMigracion.Modelos;

[Table("articulos")]
public record Articulo
{
    [Key]
    [Column("cod_art")]
    public int ArticuloID { get; set; }

    [Column("descripcion")]
    public string? Descripcion { get; set; }

    [Column("precio")]
    public string? Precio { get; set; }

    [Column("status")]
    public string? Status { get; set; }

    [Column("imagen")]
    public string? Imagen { get; set; }

    // Map FK to the provider key column name
    [Column("cod_prv")]
    public int ProveedorID { get; set; }

    [ForeignKey(nameof(ProveedorID))]
    public Proveedor? Proveedor { get; set; }

    public ICollection<DetalleNotaVenta> DetallesNotaVenta { get; } = new List<DetalleNotaVenta>();
}

