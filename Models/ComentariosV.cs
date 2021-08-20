using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Models
{		[Table("ComentariosVehiculos")]
    public class ComentariosV
    {
	
		[Key]
		public int id { get; set; }
		public string Comentario { get; set; }
		public int id_vehiculo { get; set; }

    }
}
