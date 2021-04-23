using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProyectoFinal.Models;

namespace ProyectoFinal.Services {
    public interface IReserva {
        public Task<List<ReservesDb>> GetReserves();
        public Task<ReservesDb> AddReserves(ReservesDb oReserves);
    }
}