using System.ComponentModel.DataAnnotations;

namespace MtoMigracion.Modelos;

public record Articulo
{
    [Key] public int ArticuloID { get; set; }
    public string Descripcion { get; set; }
    public string Precio { get; set; }
    public string Status { get; set; }

    // Se omitirá la implementación 
    //public string Imagen { get; set; }

    // Navigation properties
    public int ProveedorID { get; set; }
    public Proveedor Proveedor { get; set; }
    public ICollection<DetalleNotaVenta> DetallesNotaVenta { get; } = [];
}

