using System.ComponentModel.DataAnnotations;

namespace DC_DentalCare.Models
{
    public class Especialidad
    {
        [Key]
        public int Id { get; set; } 
        public string Nombre { get; set; }
    }
}
