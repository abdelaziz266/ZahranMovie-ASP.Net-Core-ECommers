using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZahranMovie.Data;

namespace ZahranMovie.Controllers
{
    public class ActorController : Controller
    {
        private readonly AppDbContext db;
        public ActorController(AppDbContext _db)
        {
            db =_db;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var data = await db.Actors.ToListAsync();
            return View();
        }
    }
}
