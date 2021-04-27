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

        public async Task<List<ReservasDb>> GetReservesActivos()
        {

            var query = await (from x in context.reservas
                               where x.estado == 1
                               select x).ToListAsync();

            return query;

        }

        public async Task<ReservasDb> Actualizar(ReservasDb oReserves, int objReservas)
        {


            var Reservass = await context.reservas.FindAsync(objReservas);

            if (Reservass != null)
            {
                Reservass.estado = 0;
                await context.SaveChangesAsync();
                return oReserves;
            }

            return oReserves;

        }

        public async Task<List<FacturacionDb>> GetFacturacions(){
            return await (from f in context.facturaciones
                            select f).ToListAsync();
        } 
    }
}