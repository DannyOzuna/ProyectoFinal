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

        public async Task<List<JoinReservas>> GetReservesActivos()
        {
            return await (from r in context.reservas
                                join c in context.clientes
                                on r.id_cliente equals c.id
                                join v in context.vehiculos
                                on r.id_vehiculo equals v.id
                            select new JoinReservas{
                                id = r.id,
                                cliente = c.nombre + " " + c.apellido,
                                vehiculo = v.marca + " " + v.modelo,
                                fecha_inicia = r.fecha_inicia,
                                fecha_fin = r.fecha_fin,
                                monto = r.monto,
                                estado = r.estado
                            }).ToListAsync();
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


        public async Task<ReservasDb> Getreservasjoin(int id)
        {
         return await context.reservas.FirstOrDefaultAsync(c => c.id == id);
        }


        public async Task<ReservasDb> EditarReservas(ReservasDb oReserves)
        {
            var db = await context.reservas.FindAsync(oReserves.id);
            db.estado = 0;
            context.SaveChangesAsync();

            return oReserves;
        }

    }
}