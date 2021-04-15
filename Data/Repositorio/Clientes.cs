using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Models;
using System.Linq;

namespace ProyectoFinal.Data.Repositorio{
    public class Clientes : IClientes{
        private readonly AppDbContext context;

        public Clientes(AppDbContext context){
            this.context  = context;
        }
        public async Task<List<ClientesDb>> GetClientes(){
            return await context.clientes.ToListAsync();
        }

        public async Task<ClientesDb> AddCliente(ClientesDb oCliente){
            if(oCliente != null){
                await context.clientes.AddAsync(oCliente);
                await context.clientes.SaveChangesAsync();
                return oCliente;
            }else{
                return new ClientesDb();
            }
        }
    }
}