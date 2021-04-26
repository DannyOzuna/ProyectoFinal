using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Models
{
    public class LoginDb
    {
        [Key]
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
    }
}
