using System.ComponentModel.DataAnnotations;
namespace ProyectoFinal.Models{
    public class Facturacion{
        [Key]
        public int id { get; set;}
        public int id_reserva {get; set;}
        public int id_vehiculo {get;set;}
        public int id_cliente {get; set;}
        public decimal monto{get; set;}
    }
}