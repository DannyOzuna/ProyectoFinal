using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Models
{
    public class JoinVehiculosReserva
    {
        public DateTime? fecha_inicia { get; set; }
        public DateTime? fecha_fin { get; set; }
        public string foto { get; set; }
        public string marca { get; set; }
        public string tipo { get; set; }
        public string modelo { get; set; }
        public string anio { get; set; }
        public string color { get; set; }


    }
}