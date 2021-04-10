using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Models;

namespace ProyectoFinal.Data.Repositorio{
    public class Vehiculos : IVehiculos{
        
        public readonly AppDbContext context;
        public Vehiculos(AppDbContext context){
            this.context = context;
        }

        public async Task<List<VehiculosDb>> GetVehiculos(){
            return await context.vehiculos.ToListAsync();
        }

        public async Task<VehiculosDb> AddVehiculos(VehiculosDb oVehiculo){
            if(oVehiculo != null){
                await context.AddAsync(oVehiculo);
                await context.SaveChangesAsync();
                return oVehiculo;
            }else{
                return new VehiculosDb();
            }
        }
    }
}