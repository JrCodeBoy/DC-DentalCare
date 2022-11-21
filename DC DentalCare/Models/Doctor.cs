using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DC_DentalCare.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        [ForeignKey("IdEspecialidad")]
        public int  IdEspecialidad { get; set; }
    }
}
