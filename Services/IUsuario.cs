using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProyectoFinal.Models;

namespace ProyectoFinal.Services{
    public interface IUsuario {
        public Task<List<UsuariosDb>> GetUsuarios();
        public Task<UsuariosDb> AddUsuarios(UsuariosDb oUsuario);
        public Task DeleteUsuario(int i);

        public bool SearchUsuario(UsuariosDb oUsuario);
    }
}