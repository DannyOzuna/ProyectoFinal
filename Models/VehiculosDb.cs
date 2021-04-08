using System;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models{
    public class VehiculosDb{
        [Key]
        public int id {get; set;}
        public string marca {get; set;}
        public string modelo {get; set;}
        public string anio {get; set;}
        public string color{get; set;}
        public decimal precio {get; set;}
        public string tipo {get; set;}
        public double capacidad {get; set;}
        public int pasajeros {get; set;}
        public string matricula {get; set;}
        public string nro_seguro {get; set;}
        public string foto {get; set;}
        public string latitud {get; set;}
        public string longitud {get; set;}


    }
}