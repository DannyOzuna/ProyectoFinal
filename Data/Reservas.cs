using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProyectoFinal.Models;
using ProyectoFinal.Services;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ProyectoFinal.Data{
    public class Reservas : IReservas{
        public readonly AppDbContext context;

        public Reservas(AppDbContext context){
            this.context = context;
        }
        public async Task<List<ReservasDb>> GetReserves(){
           return await context.reservas.ToListAsync();
        }

        public async Task<ReservasDb> AddReserves(ReservasDb oReserves){
            if(oReserves != null){
                oReserves.fecha_inicia = DateTime.Parse(oReserves.fecha_inicia.Value.ToString("MM/dd/yyyy"));
                oReserves.fecha_fin = DateTime.Parse(oReserves.fecha_fin.Value.ToString("MM/dd/yyyy"));

                await context.AddAsync(oReserves);
                await context.SaveChangesAsync();
                return oReserves;

            }else{
                return new ReservasDb();
            }
        }  
    }
}