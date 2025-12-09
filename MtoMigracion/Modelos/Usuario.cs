using System.ComponentModel.DataAnnotations.Schema;

namespace MtoMigracion.Modelos
{
    [Table("usuarios")] 
    public class Usuario
    {
        [Column("usuario")]
        public string UsuarioId { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; } = "";

        [Column("ap_paterno")]
        public string ApPaterno { get; set; } = "";

        [Column("ap_Materno")]
        public string ApMaterno { get; set; } = "";

        [Column("contrasena")]
        public string Contrasena { get; set; } = "";
    }
}
