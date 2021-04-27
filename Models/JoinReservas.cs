using System;

namespace ProyectoFinal.Models{
    public class JoinReservas{
        public int id {get; set;}
        public string cliente {get; set;}
        public string vehiculo {get;set;}
        public DateTime? fecha_inicia {get; set;}
        public DateTime? fecha_fin {get; set;}
        public decimal monto {get; set;}
        public int estado {get; set;}
    }
}