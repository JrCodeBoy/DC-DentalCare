using System.ComponentModel.DataAnnotations;

namespace DC_DentalCare.Models
{
    public class Horario
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }    //o hacerlo con una lista
    }
}
