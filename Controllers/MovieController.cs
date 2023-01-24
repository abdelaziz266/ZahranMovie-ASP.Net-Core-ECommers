using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZahranMovie.Data;

namespace ZahranMovie.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext db;
        public MovieController(AppDbContext _db)
        {
            db = _db;
        }

        public async Task<IActionResult> Index()
        {
            var data = await db.Movies.Include(M=>M.Cinema).ToListAsync();
            return View(data);
        }
    }
}
