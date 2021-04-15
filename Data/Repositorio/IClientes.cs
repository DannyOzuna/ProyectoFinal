using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProyectoFinal.Models;

namespace ProyectoFinal.Data.Repositorio{
    public interface IClientes{
        public Task<List<ClientesDb>> GetClientes();
        public Task<ClientesDb> AddCliente(ClientesDb oCliente);
    }
}