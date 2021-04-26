  
using System;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Models;

namespace ProyectoFinal.Data{
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions options) : base(options){

        }

        public DbSet<VehiculosDb> vehiculos {get; set;}
        public DbSet<ClientesDb> clientes {get; set;}
        public DbSet<ReservasDb> reservas {get; set;}
<<<<<<< HEAD
        public DbSet<LoginDb> loginDbs { get; set; }
=======
        public DbSet<FacturacionDb> facturaciones {get; set;}
>>>>>>> fc3a66b38d318153df5991e84af4a68a60b20b87
    }
}