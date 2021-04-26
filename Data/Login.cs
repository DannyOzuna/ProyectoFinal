using ProyectoFinal.Models;
using ProyectoFinal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Data
{
    public class Login : Ilogin
    {
        private readonly AppDbContext context;

        public Login(AppDbContext context)
        {
            this.context = context;
        }

        public List<LoginDb> buscar(LoginDb datosLogin)
        {

            var query = context.loginDbs.Where(x => x.Contrasena == datosLogin.Contrasena && x.Usuario == datosLogin.Usuario);

            //var query = (from x in context.loginDbs
            //             where x.Usuario == datosLogin.Usuario &&
            //             x.Contrasena == datosLogin.Contrasena
            //             select x).ToList();
            if (query == null)
            {
                return null;
            }
            return query.ToList();
        }
    }
}
