using Microsoft.AspNetCore.Mvc;
using MarvelMoviesAPI.Services;

namespace MarvelMoviesAPI.Controllers
{
    [Route("api/[controller]")]
    public class MarvelMoviesController : Controller
    {
        private MarvelMoviesDbContext _context;

        public MarvelMoviesController(MarvelMoviesDbContext context)
        {
            _context = context;
        }

        public IActionResult GetMarvelMovies()
        {
            return Ok(_context.MarvelMovies);
        }
    }
}