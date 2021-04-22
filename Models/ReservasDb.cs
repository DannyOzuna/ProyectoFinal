using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models{
    public class ReservesDb{
        [Key]
        public int id {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public int id_vehiculo {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public int id_cliente {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public DateTime? fecha_inicia {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public DateTime? fecha_fin {get; set;}
        public int estado {get; set;}
    }
}