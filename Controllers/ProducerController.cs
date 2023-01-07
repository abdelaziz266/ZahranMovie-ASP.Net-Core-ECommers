using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZahranMovie.Data;

namespace ZahranMovie.Controllers
{
    public class ProducerController : Controller
    {
        private readonly AppDbContext db;
        public ProducerController(AppDbContext _db) { 
            db= _db;
        }
        public async Task<IActionResult> Index()
        {
            var data = await db.Producers.ToListAsync();
            return View();
        }
    }
}
