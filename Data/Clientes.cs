using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Services;
using ProyectoFinal.Models;
using System.Linq;

namespace ProyectoFinal.Data{
    public class Clientes : IClientes{
        private readonly AppDbContext context;

        public Clientes(AppDbContext context){
            this.context  = context;
        }
        public async Task<List<ClientesDb>> GetClientes(){
            return await context.clientes.ToListAsync();
        }

        public async Task<ClientesDb> GetClientes(int id){
            return await context.clientes.FirstOrDefaultAsync(c => c.id == id);
        }

        public async Task<List<ClientesDb>> GetSelectCliente(){
            return await context.clientes.Where(c => c.estado == 1).ToListAsync();
        }
        public async Task<ClientesDb> SearchCliente(string cedula){
            if(cedula != null){
                var buscar = await context.clientes.FirstOrDefaultAsync(c => c.cedula == cedula);
                if(buscar != null){
                    return buscar;
                }else{
                    return null;
                }
            }else{
                return new ClientesDb();
            }
        }


        public async Task<ClientesDb> AddCliente(ClientesDb oCliente){
            if(oCliente != null){
                var crear = await context.clientes.FirstOrDefaultAsync(c => c.id == oCliente.id || c.cedula == oCliente.cedula);
                if(crear != null){
                    return null;
                }else{
                    await context.AddAsync(oCliente);
                    await context.SaveChangesAsync();
                    return oCliente;
                }
            }else{
                return new ClientesDb();
            }
        }

        public async Task<ClientesDb> UpdateCliente(int id, ClientesDb oCliente){
            if(id != 0){
                var clienteDb = await context.clientes.FindAsync(id);
                clienteDb.nombre = oCliente.nombre;
                clienteDb.apellido = oCliente.apellido;
                clienteDb.cedula = oCliente.cedula;
                clienteDb.correo = oCliente.correo;
                clienteDb.licencia = oCliente.licencia;
                clienteDb.nacionalidad = oCliente.nacionalidad;
                clienteDb.tipo_sangre = oCliente.tipo_sangre;
                clienteDb.foto_licencia = oCliente.foto_licencia;
                clienteDb.foto_persona = oCliente.foto_persona;
                clienteDb.estado = oCliente.estado;
                await context.SaveChangesAsync();
                return oCliente;
            }else{
                return null;
            }
        }

        public async Task DeleteCliente(int id){
            var clienteDb = await context.clientes.FindAsync(id);
            context.Remove(clienteDb);
            await context.SaveChangesAsync();
        }
    }
}