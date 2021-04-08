using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProyectoFinal.Models;

namespace ProyectoFinal.Data.Repositorio{
    public interface IVehiculos{
        public Task<List<VehiculosDb>> GetVehiculos();
    }
}