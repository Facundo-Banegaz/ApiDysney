using Microsoft.EntityFrameworkCore;
using WebApiDisney.Models;

namespace WebApiDisney.Data
{
    public class DisneyContext: DbContext
    {
        public DisneyContext(DbContextOptions<DisneyContext> options): base(options) 
        {
        
        }

        public DbSet<Personaje> Personajes { get; set; }

        public DbSet<Genero> Generos { get; set; }

        public DbSet<Pelicula> Peliculas { get; set; }
    }
}
