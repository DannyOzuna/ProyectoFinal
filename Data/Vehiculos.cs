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

        public async Task<List<VehiculosDb>> GetSelect(DateTime? time){

            return await (from v in context.vehiculos
                            join r in context.reservas
                            on v.id equals r.id_vehiculo into joined
                            from r in joined.DefaultIfEmpty()
                            where v.estado == 1 || r.fecha_fin > time
                            select v).ToListAsync();
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
           var VehiculoDd =  await context.vehiculos.FindAsync(id);
           context.Remove(VehiculoDd);
           await context.SaveChangesAsync();
        }
        


    }
}