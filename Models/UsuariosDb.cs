using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models{
    public class UsuariosDb{
        [Key]
        public int id {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string user_ {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string pass {get; set;}
        public int estado {get; set;}
    }
}