using System.ComponentModel.DataAnnotations;

namespace DC_DentalCare.Models
{
    public class Fecha
    {
        [Key]
        public int Id { get; set; }
        public String Valor { get; set; }


    }
}
