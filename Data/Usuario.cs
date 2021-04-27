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
    }
}