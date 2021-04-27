  
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
        public DbSet<LoginDb> loginDbs { get; set; }

    }
}