using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProyectoFinal.Models;
using ProyectoFinal.Services;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal.Data{
    public class Reservas : IReserva{
        public readonly AppDbContext context;

        public Reservas(AppDbContext context){
            this.context = context;
        }
        public async Task<List<ReservesDb>> GetReserves(){
           return await context.reservas.ToListAsync();
        }   
    }
}