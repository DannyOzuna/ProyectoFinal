using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProyectoFinal.Models;

namespace ProyectoFinal.Services {
    public interface IReservas {
        public Task<List<ReservasDb>> GetReserves();
        public Task<ReservasDb> AddReserves(ReservasDb oReserves);
<<<<<<< HEAD
        public Task<List<ReservasDb>> GetReservesActivos();
        public Task<ReservasDb> Actualizar(ReservasDb oReserves, int objReservas);
=======
        public Task<List<FacturacionDb>> GetFacturacions();
>>>>>>> fc3a66b38d318153df5991e84af4a68a60b20b87
    }
}