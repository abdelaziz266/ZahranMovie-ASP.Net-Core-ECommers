using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZahranMovie.Data;

namespace ZahranMovie.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AppDbContext db;
        public CinemaController(AppDbContext _db)
        {
            db = _db;
        }

        public async Task<IActionResult> Index()
        {
            var data = await db.Cinemas.ToListAsync();
            return View();
        }
    }
}
