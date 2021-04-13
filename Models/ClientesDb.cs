using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models{
    public class ClientesDb{
        [Key]
        public int id {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        [MaxLength(length:11)]
        public string cedula {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string nombre {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string apellido {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string correo {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string licencia {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string nacionalidad {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string tipo_sangre {get; set;}
        public string foto_persona {get; set;}
        public string foto_licencia {get; set;}
        public int estado {get; set;}

    }
}