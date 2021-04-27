using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Models;
using ProyectoFinal.Services;
using System.Linq;

namespace ProyectoFinal.Data{
    public class Vehiculos : IVehiculos{
        
        private readonly AppDbContext context;
        public Vehiculos(AppDbContext context){
            this.context = context;
        }

        public async Task<List<VehiculosDb>> GetVehiculos(){
            return await context.vehiculos.OrderByDescending(v => v.id).ToListAsync();
        }

        public async Task<VehiculosDb> GetVehiculos(int id){
            return await context.vehiculos.FirstOrDefaultAsync(v => v.id == id);
        }

        public async Task<VehiculosDb> GetSelect(DateTime? time, int id){

            var datos = await (from v in context.vehiculos
                            join r in context.reservas
                            on v.id equals r.id_vehiculo into joined
                            from r in joined.DefaultIfEmpty()
                            orderby r.id descending
                            where r.id_vehiculo == id && r.fecha_fin > time
                            select v).LastOrDefaultAsync();

            if(datos == null){
                return null;
            }else{
                return datos;
            }
        }

        public async Task<VehiculosDb> AddVehiculos(VehiculosDb oVehiculo){
            if(oVehiculo != null){
                var crear = await context.vehiculos.FirstOrDefaultAsync(v => v.id == oVehiculo.id || v.matricula == oVehiculo.matricula);

                if(crear != null){
                    return null;
                }else{
                    await context.AddAsync(oVehiculo);
                    await context.SaveChangesAsync();
                    return oVehiculo;
                }
            }else{
                return new VehiculosDb();
            }
        }

        public async Task<VehiculosDb> UpdateVehiculo(int id,VehiculosDb oVehiculo){
            if(id != 0){
                var VehiculoDd = await context.vehiculos.FindAsync(id);
                VehiculoDd.marca = oVehiculo.marca;
                VehiculoDd.modelo = oVehiculo.modelo;
                VehiculoDd.anio = oVehiculo.anio;
                VehiculoDd.color = oVehiculo.color;
                VehiculoDd.precio = oVehiculo.precio;
                VehiculoDd.tipo = oVehiculo.tipo;
                VehiculoDd.capacidad = oVehiculo.capacidad;
                VehiculoDd.pasajeros = oVehiculo.pasajeros;
                VehiculoDd.matricula = oVehiculo.matricula;
                VehiculoDd.nro_seguro = oVehiculo.nro_seguro;
                VehiculoDd.foto = oVehiculo.foto;
                VehiculoDd.latitud = oVehiculo.latitud;
                VehiculoDd.longitud = oVehiculo.longitud;
                VehiculoDd.estado  = oVehiculo.estado;

                await context.SaveChangesAsync();
                return oVehiculo;
            }else{
                return null;
            }
        }

        public async Task DeleteVehiculo(int id){
            if(id != 0){
                var VehiculoDd =  await context.vehiculos.FindAsync(id);
                context.Remove(VehiculoDd);
                await context.SaveChangesAsync();
            }
        }

        public int ContarVehiculo() 
        {

            var query =  (from x in context.vehiculos
                          where x.estado == 1
                        select x).Count();

            return query;


        }



        public int VehiculosActivos()
        {
            var query = (from x in context.vehiculos
                         where x.estado == 0
                         select x).Count();

            return query;
        }
        public int TotalVehiculos()
        {
            var query = (from x in context.vehiculos
                         select x).Count();

            return query;
        }




        public async Task<List<JoinVehiculosReserva>> getRangoVehiculos(DateTime? fechaInicio, DateTime? fechaFinal)
        {
            return await (from v in context.vehiculos
                          join r in context.reservas
                          on v.id equals r.id_vehiculo into joined
                          from r in joined.DefaultIfEmpty()
                          where v.estado == 1 || (fechaFinal >= r.fecha_inicia && fechaFinal <= r.fecha_fin)
                          select new JoinVehiculosReserva
                          {
                              fecha_inicia = r.fecha_inicia,
                              fecha_fin = r.fecha_fin,
                              foto = v.foto,
                              modelo = v.modelo,
                              marca = v.marca,
                              tipo = v.tipo,
                              color = v.color,
                              anio = v.anio
                          }).ToListAsync();
        }



    }
}