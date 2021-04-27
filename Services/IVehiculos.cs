using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProyectoFinal.Models;

namespace ProyectoFinal.Services{
    public interface IVehiculos{
        public Task<List<VehiculosDb>> GetVehiculos();
        public Task<VehiculosDb> GetVehiculos(int id);
        public Task<VehiculosDb> GetSelect(DateTime? time, int id);
        public Task<VehiculosDb> AddVehiculos(VehiculosDb oVehiculo);
        public Task<VehiculosDb> UpdateVehiculo(int id,VehiculosDb oVehiculo);
        public Task DeleteVehiculo(int id);
        public int ContarVehiculo();
        public int VehiculosActivos();
        public int TotalVehiculos();
        public Task<List<JoinVehiculosReserva>> getRangoVehiculos(DateTime? fechaInicio, DateTime? fechaFinal);

    }
}