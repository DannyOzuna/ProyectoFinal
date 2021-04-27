 using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Services;
using ProyectoFinal.Models;
using System.Linq;

namespace ProyectoFinal.Data{
    public class Usuarios : IUsuario{
        public readonly AppDbContext context;

        public Usuarios(AppDbContext context){
            this.context = context;
        }

        public async Task<List<UsuariosDb>> GetUsuarios(){
            return await context.usuarios.ToListAsync();
        }

        public async Task<UsuariosDb> AddUsuarios(UsuariosDb oUsuario){
            oUsuario.estado = 1;
            await context.AddAsync(oUsuario);
            await context.SaveChangesAsync();
            return oUsuario;
            
        }

        public async Task DeleteUsuario(int id){
            var rs = await context.usuarios.FindAsync(id);
            context.Remove(rs);
            await context.SaveChangesAsync();
        }

        public bool SearchUsuario(UsuariosDb oUsuario) {
            if(oUsuario.user_ != "" && oUsuario.pass != ""){
                var datos = (from u in context.usuarios
                            where u.user_ == oUsuario.user_ && u.pass == oUsuario.pass && u.estado == 1
                                select u).Count();
                if(datos != 0){
                    return true;
                }
            }else{
                return false;
            }

            return false;
        }
    }
}