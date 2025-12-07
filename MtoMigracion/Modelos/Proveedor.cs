using System.ComponentModel.DataAnnotations;

namespace MtoMigracion.Modelos;

public record Proveedor
{
    [Key] public int ProveedorID { get; set; }
    public string Nombre { get; set; }
    // !!! La interfaz no está normalizada
    //public string ApellidoPat { get; set; }
    //public string ApellidoMat { get; set; }
    public string RazonSocial { get; set; }
    public string Direccion { get; set; }
    // !!! La interfaz no está normalizada
    //public string NumDomicilio { get; set; }
    //public string Calle { get; set; }
    //public string EntreCalle1 { get; set; }
    //public string EntreCalle2 { get; set; }
    //public string Colonia { get; set; }
    //public string CodPostal { get; set; }
    public string Telefono { get; set; }
    // Supongo que esto se puede obtener de el telefono
    // vamos a ignorarlo de momento
    //public string Extension { get; set; }
    public string RFC { get; set; }
    public string Email { get; set; }
    public string Status { get; set; }

    // Navigation properties
    public ICollection<Articulo> Articulos { get; } = [];
}