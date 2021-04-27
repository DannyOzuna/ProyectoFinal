using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProyectoFinal.Models;

namespace ProyectoFinal.Services{
    public interface IClientes{
        public Task<List<ClientesDb>> GetClientes();
        public Task<ClientesDb> GetClientes(int id);
        public Task<List<ClientesDb>> GetSelectCliente();
        public Task<ClientesDb> SearchCliente(string cedula);
        public Task<ClientesDb> AddCliente(ClientesDb oCliente);
        public Task<ClientesDb> UpdateCliente(int id, ClientesDb oCliente);
        public Task DeleteCliente(int id);
    }
}