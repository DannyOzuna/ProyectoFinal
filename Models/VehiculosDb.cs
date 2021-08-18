using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal.Models{
    [Table("vehiculos")]
    public class VehiculosDb{
        [Key]
        public int id {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string marca {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string modelo {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string anio {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string color{get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public decimal precio {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string tipo {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public double capacidad {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public int pasajeros {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string matricula {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string nro_seguro {get; set;}
        public string foto {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string latitud {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string longitud {get; set;}
        public int estado {get; set;}
        public string comentarios { get; set;}
        public string condision { get; set;}
        
    }
}