using Microsoft.AspNetCore.Mvc;
using tyuiu.teacher221.SidorovAY.Recipies.Data;

namespace tyuiu.teacher221.SidorovAY.Recipies.Controllers
{
    public class MapController : Controller
    {
        public IActionResult Index()
        {
            var rects = new List<Room>() {
                new Room() { Number="101", X=100, Y=100, Width=100, Height=100 },
                new Room() { Number="102", X=100, Y=200, Width=100, Height=100 },
                new Room() { Number="103", X=100, Y=300, Width=100, Height=100 },
                new Room() { Number="101", X=200, Y=100, Width=100, Height=100 },
                new Room() { Number="102", X=200, Y=200, Width=100, Height=100 },
                new Room() { Number="103", X=200, Y=300, Width=100, Height=100 }
            };
            return View(rects);
        }
    }
}
