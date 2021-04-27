using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models{
    public class UsuariosDb{
        [Key]
        public int id {get; set;}
        public string user_ {get; set;}
        public string pass {get; set;}
        public int estado {get; set;}
    }
}