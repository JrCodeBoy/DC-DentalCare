using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DC_DentalCare.Models
{
    public class Reserva
    {
        //entidad principal (agrupa a las demás)
       [Key]
       public int Id { get; set; }
       
       [ForeignKey("IdFecha")]
       public int IdFecha { get; set; }

       [ForeignKey("IdHorario")]
       public int IdHorario { get; set; }

       [ForeignKey("IdDoctor")]
       public int IdDoctor { get; set; }

       [ForeignKey("IdEstado")]
       public int IdEstado { get; set; }
        
    }
}
