using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DC_DentalCare.Models
{
    public class Reserva
    {
        [Key]
       public int Id { get; set; }
       public DateTime Fecha { get; set; }
       public String NombreDoctor{ get; set; }
       public String NombreEspecialidad { get; set; }
       public Estado Estado { get; set; }
        
    }
}
