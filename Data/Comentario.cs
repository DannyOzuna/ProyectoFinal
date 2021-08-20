using ProyectoFinal.Models;
using ProyectoFinal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.Data
{
    public class Comentario : IComentario
    {
        private readonly AppDbContext context;

        public Comentario(AppDbContext context)
        {
            this.context = context;
        }

        public bool Agregar(ComentariosV comentar)
        {
            comentar.id = 0;
            context.comentarios.Add(comentar);
            context.SaveChanges();
            return true;
        }

        public List<ComentariosV> Buscar(int id)
        {
            var query = from x in context.comentarios
                        where x.id_vehiculo == id
                        select x;
            return query.ToList();
        }

      
    }
}
