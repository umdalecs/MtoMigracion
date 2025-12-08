using System.ComponentModel.DataAnnotations;

namespace MtoMigracion.Modelos;

public record NotaVenta
{
    [Key] public int NotaVentaID { get; set; }
    public DateTime Fecha { get; set; }
    // Tecnicamente esto puede ser calculado
    //public string Importe { get; set; }
    public int PorcentajeIVA { get; set; }



    // Navigation properties
    public int ClienteID { get; set; }
    public Cliente Cliente { get; set; }
    public ICollection<DetalleNotaVenta> DetallesNotaVenta { get; } = [];
}

public record DetalleNotaVenta
{
    [Key] public int DetalleNotaVentaID { get; set; }
    public int Cantidad { get; set; }
    public string PrecioUnitario { get; set; }
    // Tecnicamente esto puede ser calculado
    //public string Importe { get; set; }
    public int PorcentajeDescuento { get; set; }


    // Navigation properties
    public int NotaVentaID { get; set; }
    public NotaVenta NotaVenta { get; set; }
    public int ArticuloID { get; set; }
    public Articulo Articulo { get; set; }
}
