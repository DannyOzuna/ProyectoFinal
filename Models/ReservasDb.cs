using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal.Models {
    [Table("reservas")]
    public class ReservasDb{
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
        public decimal monto {get; set;}
        public int estado {get; set;}
    }
}