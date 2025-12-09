#nullable enable

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace MtoMigracion.Modelos
{
    [Table("proveedores")]
    public class Proveedor
    {
        [Key]
        [Column("cod_prv")]
        public int ProveedorID { get; set; }

        [Column("nombre")]
        public string? Nombre { get; set; }

        [Column("razon_social")]
        public string? RazonSocial { get; set; }

        [Column("rfc")]
        public string? RFC { get; set; }

        [Column("email")]
        public string? Email { get; set; }

        [Column("telefono")]
        public string? Telefono { get; set; }

        [Column("celular")]
        public string? Celular { get; set; }

        [Column("banco")]
        public string? Banco { get; set; }

        [Column("cuenta")]
        public string? Cuenta { get; set; }

        [Column("vendedor")]
        public string? Vendedor { get; set; }

        [Column("telefonoVendedor")]
        public string? TelefonoVendedor { get; set; }

        [Column("status")]
        public string? Status { get; set; }

        [NotMapped]
        public string? Direccion { get; set; }

        public ICollection<Articulo> Articulos { get; } = new List<Articulo>();

    }
}
