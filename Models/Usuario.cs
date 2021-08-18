using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoFinal.Models{
    [Table("Usuarios")]
    public class Usuario{
        [Key]
        public int id {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string user_ {get; set;}
        [Required(ErrorMessage = "Campo Vacio")]
        public string pass {get; set;}
        public int estado {get; set;}
    }
}