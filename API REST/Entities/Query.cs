using System.ComponentModel.DataAnnotations;

namespace API_REST.Entities
{
    public class Query
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} no puede ir vacio")]
        public string Usuario { get; set; }  = null!;
        public string Request { get; set; } = null!;
        public DateTime FechaRequest { get; set; }
        public string Response { get; set; }  = null!;
        public DateTime FechaResponse { get; set; }

    }
}
