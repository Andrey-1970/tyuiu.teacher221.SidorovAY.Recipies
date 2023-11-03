using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tyuiu.teacher221.SidorovAY.Recipies.Data;

namespace tyuiu.teacher221.SidorovAY.Recipies.Controllers
{
    public class RecipiesController : Controller
    {
        private readonly AppDBContext context;

        public RecipiesController(AppDBContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Recipes.Include("Ingridients"));
        }
    }
}
