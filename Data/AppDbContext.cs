  
using System;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Models;

namespace ProyectoFinal.Data{
    public class AppDbContext : DbContext{
        public AppDbContext(DbContextOptions options) : base(options){

        }

        public DbSet<VehiculosDb> vehiculos {get; set;}
        public DbSet<clientes> clientes {get; set;}
        public DbSet<ReservasDb> reservas {get; set;}
        public DbSet<LoginDb> loginDbs { get; set; }
        public DbSet<Usuario> usuario {get; set;}
        public DbSet<ComentariosV> comentarios { get; set; }

    }
}