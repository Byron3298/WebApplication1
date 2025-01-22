using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Lugar
    {
        [Key]
        public int UbicacionId { get; set; }

        [ForeignKey("Evento")]
        public int EventoId { get; set; }


        public string Direccion { get; set; }

        public Evento Evento { get; set; }
    }
}
