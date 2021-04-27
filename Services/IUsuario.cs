using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProyectoFinal.Models;

namespace ProyectoFinal.Models{
    public interface IUsuario {
        public Task<List<UsuariosDb>> GetUsuarios();
    }
}