
using System.ComponentModel.DataAnnotations;

namespace ApiDriver.Models
{
    public class Conductores
    {
        [Key]
        public int condId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? nroTele { get; set; }
        
        //public double lantitud { get; set; }
        //public double Longitud { get; set; }
    }
}
