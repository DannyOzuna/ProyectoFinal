using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Services
{
    public interface Ilogin
    {
        public List<LoginDb> buscar(LoginDb login);
    }
}
