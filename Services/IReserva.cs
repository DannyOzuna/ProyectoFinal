using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProyectoFinal.Models;

namespace ProyectoFinal.Services {
    public interface IReservas {
        public Task<List<ReservasDb>> GetReserves();
        public Task<ReservasDb> AddReserves(ReservasDb oReserves);
        public Task<List<ReservasDb>> GetReservesActivos();
        public Task<ReservasDb> Actualizar(ReservasDb oReserves, int objReservas);
        public Task<List<FacturacionDb>> GetFacturacions();
    }
}