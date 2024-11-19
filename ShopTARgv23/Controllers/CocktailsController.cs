using Microsoft.AspNetCore.Mvc;

namespace ShopTARgv23.Controllers
{
    public class CocktailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
