﻿using System.ComponentModel.DataAnnotations;

namespace DC_DentalCare.Models
{
    public class Estado
    {
        [Key]
        public int Id { get; set; }

        //ESTADO: DISPONIBLE-NO DISPONIBLE
        public String? Nombre { get; set; }
    }
}