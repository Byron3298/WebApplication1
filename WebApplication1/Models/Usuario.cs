using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Usuario
    {
        // Id de usuario (clave primaria)
        [Key]
        public int UsuarioId { get; set; }

        public string Nombre { get; set; }

        public string Correo { get; set; }

        public string Telefono { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}
