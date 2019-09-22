using Microsoft.EntityFrameworkCore;
using MarvelMoviesAPI.Entities;

namespace MarvelMoviesAPI.Services
{
    public class MarvelMoviesDbContext : DbContext
    {
        public DbSet<MarvelMovie> MarvelMovies { get; set; }

        public MarvelMoviesDbContext(DbContextOptions<MarvelMoviesDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}