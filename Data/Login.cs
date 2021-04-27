using ProyectoFinal.Models;
using ProyectoFinal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Data
{
    public class Login : ILogin
    {
        private readonly AppDbContext context;

        public Login(AppDbContext context)
        {
            this.context = context;
        }

        public bool buscar(LoginDb datosLogin)
        {


            if (datosLogin.Usuario != "" || datosLogin.Contrasena != "")
            {
            var query = context.loginDbs.Where(x => x.Contrasena == datosLogin.Contrasena && x.Usuario ==
            datosLogin.Usuario);
                if (query == null)
                {
                    return false;
                }

            }

            else
            {
                return false;
            }

           

            return true;

        }
    }
}
