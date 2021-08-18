using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProyectoFinal.Models;

namespace ProyectoFinal.Services{
    public interface IClientes{
        public Task<List<clientes>> GetClientes();
        public Task<clientes> GetClientes(int id);
        public Task<List<clientes>> GetSelectCliente();
        public Task<clientes> SearchCliente(string cedula);
        public Task<clientes> AddCliente(clientes oCliente);
        public Task<clientes> UpdateCliente(int id, clientes oCliente);
        public Task DeleteCliente(int id);
    }
}