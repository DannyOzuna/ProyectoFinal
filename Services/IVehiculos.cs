using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProyectoFinal.Models;

namespace ProyectoFinal.Services{
    public interface IVehiculos{
        public Task<List<VehiculosDb>> GetVehiculos();
        public Task<VehiculosDb> GetVehiculos(int id);

        public Task<List<VehiculosDb>> GetSelect(DateTime? time);

        public Task<VehiculosDb> AddVehiculos(VehiculosDb oVehiculo);
        public Task<VehiculosDb> UpdateVehiculo(int id,VehiculosDb oVehiculo);

        public Task DeleteVehiculo(int id);
    }
}