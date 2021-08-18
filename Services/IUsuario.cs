using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProyectoFinal.Models;

namespace ProyectoFinal.Services{
    public interface IUsuario {
        public Task<List<Usuario>> GetUsuarios();
        public Task<Usuario> AddUsuarios(Usuario oUsuario);
        public Task DeleteUsuario(int i);

        public bool SearchUsuario(Usuario oUsuario);
    }
}